using RecipeApp;
using System.Collections.Generic;
using System.Windows;
using MahApps.Metro.Controls;

namespace RecipeAppWPF
{
    // Main window of the application, inherits from MetroWindow for enhanced styling
    public partial class MainWindow : MetroWindow
    {
        // Static list to hold all recipes, accessible globally within the application
        public static List<Recipe> Recipes = new List<Recipe>();

        // Constructor for the MainWindow class
        public MainWindow()
        {
            InitializeComponent();
            LoadRecipes();
            // Display a welcome message when the application starts
            MessageBox.Show("Welcome to Sanele's recipe application!");
        }

        // Method to load the recipes into the ListView
        private void LoadRecipes()
        {
            // Reset the ItemsSource to refresh the ListView
            RecipeListView.ItemsSource = null;
            RecipeListView.ItemsSource = Recipes;
        }

        // Event handler for the Add New Recipe button click event
        private void AddNewRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the AddRecipePage window to add a new recipe
            var addRecipePage = new AddRecipePage();
            addRecipePage.ShowDialog();
            // Reload the recipes list after a new recipe is added
            LoadRecipes();
        }

        // Event handler for the View Recipe Menu button click event
        private void ViewRecipeMenuButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the CreateMenuPage window to view and generate a recipe menu
            var createMenuPage = new CreateMenuPage();
            createMenuPage.ShowDialog();
        }
    }
}

//--------------------------------------------------------EOF--------------------------------------------------------------------------------//