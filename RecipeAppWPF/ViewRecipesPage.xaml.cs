using RecipeApp;
using System.Linq;
using System.Windows.Controls;


namespace RecipeAppWPF
{
    // Page for viewing recipes, inherits from Page
    public partial class ViewRecipesPage : Page
    {
        // Constructor for the ViewRecipesPage class
        public ViewRecipesPage()
        {
            InitializeComponent();
            LoadRecipes();
        }

        // Method to load and display the recipes in the ListBox
        private void LoadRecipes()
        {
            // Get the list of recipes sorted by name
            var recipes = Program.recipes.OrderBy(r => r.Name).ToList();
            // Set the ItemsSource of the ListBox to the sorted list of recipes
            RecipesListBox.ItemsSource = recipes;
        }

        // Event handler for the ListBox selection changed event
        private void RecipesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Check if a recipe is selected in the ListBox
            if (RecipesListBox.SelectedItem is Recipe selectedRecipe)
            {
                // Display the details of the selected recipe in the RecipeDetails TextBlock
                RecipeDetails.Text = selectedRecipe.GetRecipeDetails();
            }
        }
    }
}

//--------------------------------------------------------EOF--------------------------------------------------------------------------------//