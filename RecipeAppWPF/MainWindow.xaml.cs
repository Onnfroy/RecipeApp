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
using MahApps.Metro.Controls;

namespace RecipeAppWPF
{
    public partial class MainWindow : MetroWindow
    {
        public static List<Recipe> Recipes = new List<Recipe>();

        public MainWindow()
        {
            InitializeComponent();
            LoadRecipes();
            MessageBox.Show("Welcome to Sanele's recipe application!");
        }

        private void LoadRecipes()
        {
            RecipeListView.ItemsSource = null;
            RecipeListView.ItemsSource = Recipes;
        }

        private void AddNewRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            var addRecipePage = new AddRecipePage();
            addRecipePage.ShowDialog();
            LoadRecipes(); // Reload the recipes list after a new recipe is added
        }

        private void ViewRecipeMenuButton_Click(object sender, RoutedEventArgs e)
        {
            var createMenuPage = new CreateMenuPage();
            createMenuPage.ShowDialog();
        }
    }
}