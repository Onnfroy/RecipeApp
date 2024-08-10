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
using LiveCharts;
using LiveCharts.Wpf;

namespace RecipeAppWPF
{
    public partial class CreateMenuPage : Window
    {
        public CreateMenuPage()
        {
            InitializeComponent();
            LoadRecipes();
        }

        // Loads the recipes into the ListBox for selection
        private void LoadRecipes()
        {
            RecipeListBox.Items.Clear();
            foreach (var recipe in MainWindow.Recipes)
            {
                RecipeListBox.Items.Add(recipe.Name);
            }
        }

        // Event handler for generating the menu and pie chart
        private void GenerateMenuButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected recipes from the ListBox
            var selectedRecipes = RecipeListBox.SelectedItems.Cast<string>().ToList();
            var selectedRecipeObjects = MainWindow.Recipes.Where(r => selectedRecipes.Contains(r.Name)).ToList();

            // Ensure at least one recipe is selected
            if (selectedRecipeObjects.Count == 0)
            {
                MessageBox.Show("Please select at least one recipe.");
                return;
            }

            // Calculate the distribution of food groups by summing the calories
            var foodGroupDistribution = selectedRecipeObjects
                .SelectMany(r => r.Ingredients)
                .GroupBy(i => i.FoodGroup)
                .Select(g => new { FoodGroup = g.Key, TotalCalories = g.Sum(i => i.Calories * i.Quantity) })
                .ToList();

            // Create the pie series for the chart
            var pieSeries = new SeriesCollection();

            foreach (var group in foodGroupDistribution)
            {
                pieSeries.Add(new PieSeries
                {
                    Title = group.FoodGroup,
                    Values = new ChartValues<double> { group.TotalCalories },
                    DataLabels = true
                });
            }

            // Assign the pie series to the PieChart control
            PieChart.Series = pieSeries;
        }
    }
}

//--------------------------------------------------------EOF--------------------------------------------------------------------------------//
