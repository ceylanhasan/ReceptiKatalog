using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReceptiKatalog
{
    public partial class LoginControl : Form
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 490);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(0, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(326, 132);
            this.label6.TabIndex = 0;
            this.label6.Text = " \"No one is born\r\n       a great cook,\r\n        one learns by doing\"\r\n           " +
    "            Julia Child";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ReceptiKatalog.Properties.Resources.female_chef_avatar_icon_vector_320954941;
            this.pictureBox1.Location = new System.Drawing.Point(33, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = " Username :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 159);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 31);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(324, 241);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 32);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(324, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Don\'t Have an Account?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(511, 279);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(526, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Register here";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(717, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "x";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(526, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Guest";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sylfaen", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(328, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 36);
            this.label8.TabIndex = 12;
            this.label8.Text = "Chef";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(640, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "x";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // LoginControl
            // 
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(672, 483);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginControl";
            this.Load += new System.EventHandler(this.LoginControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
             SignUp signForm = new SignUp();
             signForm.Show();
             this.Hide();
            

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       /* private void RegisterUser(string username, string password, string email)
        {
            using (var context = new RecipeDbContext())
            {
                var user = new User
                {
                  //  Username = username,
                  //  Password = password, // Забележка: Винаги хеширайте паролите преди да ги запишете в базата данни
                  //  Email = email,
                  //  CreatedAt = DateTime.Now
                };

                context.Users.Add(user);
                context.SaveChanges();
            }
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

        
            form2.Show();
        }

        private void btnNewRecipe_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();


            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", textBox1.Text);
                    command.Parameters.AddWithValue("@password", textBox2.Text);

                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("Login successful!");
                        Form3 form3 = new Form3();
                        form3.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
