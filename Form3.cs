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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnNewRecipe_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
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
                        // Добавяме обект от тип Recipe в ListBox
                        Recipe recipe = new Recipe { Id = reader.GetInt32("Id"), Name = reader.GetString("Name") };
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

        private void Form3_Load(object sender, EventArgs e)
        {
            // Зареждане на рецепти при зареждане на формата
            LoadRecipes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Recipe selectedRecipe = (Recipe)listBox1.SelectedItem;
                DeleteRecipeFromDatabase(selectedRecipe.Id);
                listBox1.Items.Remove(selectedRecipe);
                MessageBox.Show("Рецептата е изтрита успешно.");
            }
            else
            {
                MessageBox.Show("Моля, изберете рецепта за изтриване.");
            }
        }

        private void DeleteRecipeFromDatabase(int recipeId)
        {
            string server = "localhost";
            string database = "recipesdb";
            string username = "root";
            string password = "";

            string connectionString = $"Server={server};Database={database};User ID={username};Password={password};Pooling=false;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM recipes WHERE Id = @RecipeId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RecipeId", recipeId);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при изтриване на рецептата: " + ex.Message);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            LoginControl form = new LoginControl();
            form.Show();
            this.Hide();
        }
    }
}
