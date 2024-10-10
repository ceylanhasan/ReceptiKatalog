using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace ReceptiKatalog
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        /* SqlConnection connect = new SqlConnection(@"Server=localhost;Database=recipes;Username=root;Password=your_password;");
         public SignUp(SqlConnection connect)
         {
             InitializeComponent();
             this.connect = connect;
         }
         */

        private void label5_Click(object sender, EventArgs e)
        {
            LoginControl lgcntr = new LoginControl();
            lgcntr.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "recipesdb";
            string username = "root";
            string password = "";
            string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Проверка дали потребителското име вече съществува
                    string checkUsernameQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                    MySqlCommand checkUsernameCommand = new MySqlCommand(checkUsernameQuery, connection);
                    checkUsernameCommand.Parameters.AddWithValue("@username", textBox2.Text);

                    int usernameCount = Convert.ToInt32(checkUsernameCommand.ExecuteScalar());
                    if (usernameCount > 0)
                    {
                        MessageBox.Show($"{textBox2.Text} is already taken. Please choose another username.");
                        return;
                    }

                    // Вмъкване на новия потребител в базата данни
                    string insertQuery = "INSERT INTO Users (Username, Password, Email, Created_At) VALUES (@username, @password, @email, @created_at)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@username", textBox2.Text);
                    insertCommand.Parameters.AddWithValue("@password", textBox3.Text); // Тук следва да хеширате паролата
                    insertCommand.Parameters.AddWithValue("@email", textBox1.Text);
                    insertCommand.Parameters.AddWithValue("@created_at", DateTime.Now);

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Registration successful!");
                    this.Hide();
                    LoginControl lgcntr = new LoginControl();
                    lgcntr.Show();
                    
                    // Скриване на текущата форма след успешна регистрация
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL error number: {ex.Number}, Message: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        /* if (connect.State != ConnectionState.Open)
         {
             try
             {
                 connect.Open();
                 string checkUsername = "SELECT * FROM users WHERE username = @username";

                 using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                 {
                     checkUser.Parameters.AddWithValue("@username", textBox2.Text.Trim());
                     SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                     DataTable table = new DataTable();
                     adapter.Fill(table);

                     if (table.Rows.Count >= 1)
                     {
                         MessageBox.Show(textBox2.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                     else
                     {
                         string insertDate = "INSERT INTO users(email, username, password, created_at) " +
                                             "VALUES(@username, @password, @date)";
                         DateTime date = DateTime.Today;

                         using (SqlCommand cmd = new SqlCommand(insertDate, connect))
                         {
                             cmd.Parameters.AddWithValue("@username", textBox2.Text.Trim());
                             cmd.Parameters.AddWithValue("@password", textBox3.Text.Trim());
                             cmd.Parameters.AddWithValue("@date", date);

                             cmd.ExecuteNonQuery();

                             MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                             // Премахнете създаването на нова инстанция на SignUp тук, ако не е необходимо.
                             // SignUp sForm = new SignUp();
                             // sForm.Show();
                             this.Hide();
                         }
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             finally
             {
                 connect.Close();

]              }*/


        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.PasswordChar = '\0';
            }
            else 
            { 
                 textBox3.PasswordChar = '*';
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            LoginControl form = new LoginControl();
            form.Show();
            this.Hide();
        }
    }
}
