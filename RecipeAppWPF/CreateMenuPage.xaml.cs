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
    /// Interaction logic for CreateMenuPage.xaml
    /// </summary>
    public partial class CreateMenuPage : Page
    {
        public CreateMenuPage()
        {
            InitializeComponent();
            LoadRecipes();
        }

        private void LoadRecipes()
        {
            var recipes = Program.recipes.OrderBy(r => r.Name).ToList();
            RecipesListBox.ItemsSource = recipes;
        }

        private void GeneratePieChart_Click(object sender, RoutedEventArgs e)
        {
            var selectedRecipes = RecipesListBox.SelectedItems.Cast<Recipe>().ToList();
            if (selectedRecipes.Count == 0)
            {
                MessageBox.Show("Please select at least one recipe.");
                return;
            }

            var foodGroupCounts = new Dictionary<string, double>();

            foreach (var recipe in selectedRecipes)
            {
                foreach (var ingredient in recipe.GetIngredients())
                {
                    if (foodGroupCounts.ContainsKey(ingredient.FoodGroup))
                    {
                        foodGroupCounts[ingredient.FoodGroup] += ingredient.Quantity;
                    }
                    else
                    {
                        foodGroupCounts[ingredient.FoodGroup] = ingredient.Quantity;
                    }
                }
            }

            FoodGroupChart.Series.Clear();
            foreach (var foodGroup in foodGroupCounts)
            {
                var pieSeries = new PieSeries
                {
                    Title = foodGroup.Key,
                    Values = new ChartValues<double> { foodGroup.Value }
                };
                FoodGroupChart.Series.Add(pieSeries);
            }
        }
    }
}
