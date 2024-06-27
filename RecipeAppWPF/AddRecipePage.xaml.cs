using RecipeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecipeAppWPF
{
    public partial class AddRecipePage : Window
    {
        private List<Ingredient> ingredients = new List<Ingredient>();
        private List<Step> steps = new List<Step>();

        public AddRecipePage()
        {
            InitializeComponent();
        }

        private void AddIngredientButton_Click(object sender, RoutedEventArgs e)
        {
            string name = IngredientNameTextBox.Text.Trim();
            string quantityText = IngredientQuantityTextBox.Text.Trim();
            string unit = IngredientUnitTextBox.Text.Trim();
            string caloriesText = IngredientCaloriesTextBox.Text.Trim();
            string foodGroup = IngredientFoodGroupTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(quantityText) ||
                string.IsNullOrWhiteSpace(unit) || string.IsNullOrWhiteSpace(caloriesText) || string.IsNullOrWhiteSpace(foodGroup))
            {
                MessageBox.Show("Please fill in all ingredient fields.");
                return;
            }

            if (!double.TryParse(quantityText, out double quantity) || !int.TryParse(caloriesText, out int calories))
            {
                MessageBox.Show("Invalid quantity or calories value.");
                return;
            }

            ingredients.Add(new Ingredient
            {
                Name = name,
                Quantity = quantity,
                Unit = unit,
                Calories = calories,
                FoodGroup = foodGroup
            });

            MessageBox.Show("Ingredient added successfully!");
            IngredientNameTextBox.Clear();
            IngredientQuantityTextBox.Clear();
            IngredientUnitTextBox.Clear();
            IngredientCaloriesTextBox.Clear();
            IngredientFoodGroupTextBox.Clear();
        }

        private void FinishRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            string name = RecipeNameTextBox.Text.Trim();
            string stepsInput = StepsTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || ingredients.Count == 0 || string.IsNullOrWhiteSpace(stepsInput))
            {
                MessageBox.Show("Please fill in all fields and add at least one ingredient.");
                return;
            }

            foreach (var step in stepsInput.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
            {
                steps.Add(new Step { Description = step.Trim() });
            }

            var newRecipe = new Recipe
            {
                Name = name,
                Ingredients = ingredients,
                Steps = steps
            };

            MainWindow.Recipes.Add(newRecipe);
            MessageBox.Show("Recipe added successfully!");
            this.Close();
        }
    }
}



