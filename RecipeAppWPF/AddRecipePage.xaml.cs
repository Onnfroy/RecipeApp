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
    /// <summary>
    /// Interaction logic for AddRecipePage.xaml
    /// </summary>
    public partial class AddRecipePage : Page
    {
        public AddRecipePage()
        {
            InitializeComponent();
            recipe = new Recipe();
        }

        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            Ingredient ingredient = new Ingredient
            {
                Name = IngredientName.Text,
                Quantity = double.Parse(Quantity.Text),
                Unit = Unit.Text,
                Calories = int.Parse(Calories.Text),
                FoodGroup = FoodGroup.Text
            };
            recipe.AddIngredient(ingredient);
            MessageBox.Show("Ingredient added.");
        }

        private void SaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            recipe.Name = RecipeName.Text;
            Program.recipes.Add(recipe); // Ensure Program.recipes is public or modify as needed.
            MessageBox.Show("Recipe saved.");
        }
    }
    }

