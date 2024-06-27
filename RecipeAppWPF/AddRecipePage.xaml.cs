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
        // Lists to store ingredients and steps for the new recipe
        private List<Ingredient> ingredients = new List<Ingredient>();
        private List<Step> steps = new List<Step>();

        public AddRecipePage()
        {
            InitializeComponent();
        }

        // Event handler for adding an ingredient
        private void AddIngredientButton_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve input from text boxes
            string name = IngredientNameTextBox.Text.Trim();
            string quantityText = IngredientQuantityTextBox.Text.Trim();
            string unit = IngredientUnitTextBox.Text.Trim();
            string caloriesText = IngredientCaloriesTextBox.Text.Trim();
            string foodGroup = IngredientFoodGroupTextBox.Text.Trim();

            // Validate input fields
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(quantityText) ||
                string.IsNullOrWhiteSpace(unit) || string.IsNullOrWhiteSpace(caloriesText) || string.IsNullOrWhiteSpace(foodGroup))
            {
                MessageBox.Show("Please fill in all ingredient fields.");
                return;
            }

            // Parse quantity and calories
            if (!double.TryParse(quantityText, out double quantity) || !int.TryParse(caloriesText, out int calories))
            {
                MessageBox.Show("Invalid quantity or calories value.");
                return;
            }

            // Add the new ingredient to the ingredients list
            ingredients.Add(new Ingredient
            {
                Name = name,
                Quantity = quantity,
                Unit = unit,
                Calories = calories,
                FoodGroup = foodGroup
            });

            // Confirm ingredient addition and clear text boxes
            MessageBox.Show("Ingredient added successfully!");
            IngredientNameTextBox.Clear();
            IngredientQuantityTextBox.Clear();
            IngredientUnitTextBox.Clear();
            IngredientCaloriesTextBox.Clear();
            IngredientFoodGroupTextBox.Clear();
        }

        // Event handler for finishing the recipe
        private void FinishRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve recipe name and steps input
            string name = RecipeNameTextBox.Text.Trim();
            string stepsInput = StepsTextBox.Text.Trim();

            // Validate input fields and ingredient list
            if (string.IsNullOrWhiteSpace(name) || ingredients.Count == 0 || string.IsNullOrWhiteSpace(stepsInput))
            {
                MessageBox.Show("Please fill in all fields and add at least one ingredient.");
                return;
            }

            // Split and add steps to the steps list
            foreach (var step in stepsInput.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
            {
                steps.Add(new Step { Description = step.Trim() });
            }

            // Create and add the new recipe to the main window's recipe list
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



