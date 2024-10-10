using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ReceptiKatalog
{
    public partial class Form4 : Form
    {
        private string connectionString = $"Server=localhost;Database=recipesdb;User ID=root;Password=;Pooling=false;";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null)
            {
                string ingredient = comboBox1.SelectedItem.ToString();
                string measure = comboBox3.SelectedItem.ToString();
                string quantity = textBox3.Text;
                string listItem = $" {ingredient} {quantity} ({measure})";

                listBox1.Items.Add(listItem);
            }
            else
            {
                MessageBox.Show("Please select both an ingredient and a measure.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveRecipe();
        }
        private void SaveRecipe()
        {
            // Assuming you have text boxes with names textBoxName, textBoxCookingDescription, textBoxAuthorId, textBoxTypeId
            string name = textBox5.Text;
            string cooking_Description = richTextBox1.Text;
            int autor_Id = int.Parse(textBox1.Text);
            DateTime date_Add = DateTime.Now;
            string type_Id = textBox4.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO recipes (name, cooking_description, autor_id, date_add, type_id) VALUES (@name, @cooking_Description, @autor_Id, @date_Add, @type_Id)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@cooking_Description", cooking_Description);
                    command.Parameters.AddWithValue("@autor_Id", autor_Id);
                    command.Parameters.AddWithValue("@date_Add", date_Add);
                    command.Parameters.AddWithValue("@type_Id", type_Id);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Recipe saved successfully!");
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

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            LoginControl form = new LoginControl();
            form.Show();
            this.Hide();
        }
    }
}
