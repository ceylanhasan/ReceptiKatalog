using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ReceptiKatalog
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadRecipes();
        }

        private void LoadRecipes()
        {
            string server = "localhost";
            string database = "recipesdb";
            string username = "root";
            string password = "";

            string connectionString = $"Server={server};Database={database};User ID={username};Password={password};Pooling=false;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Id, Name FROM recipes";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    listBox1.Items.Clear();

                    while (reader.Read())
                    {
                        Recipe recipe = new Recipe
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name")
                        };
                        listBox1.Items.Add(recipe);
                    }
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Recipe selectedRecipe = (Recipe)listBox1.SelectedItem;
                LoadCookingDescription(selectedRecipe.Id);
            }
        }

        private void LoadCookingDescription(int recipeId)
        {
            string server = "localhost";
            string database = "recipesdb";
            string username = "root";
            string password = "";

            string connectionString = $"Server={server};Database={database};User ID={username};Password={password};Pooling=false;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT cooking_description FROM recipes WHERE Id = @Id";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", recipeId);
                    MySqlDataReader reader = command.ExecuteReader();

                    listBox2.Items.Clear();

                    if (reader.Read())
                    {
                        string cooking_description = reader.GetString("cooking_description");
                        listBox2.Items.Add(cooking_description);
                    }
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

        public class Recipe
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoginControl form = new LoginControl();
            form.Show();
            this.Hide();
        }
    }
}
