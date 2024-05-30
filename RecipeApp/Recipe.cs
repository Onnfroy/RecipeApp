using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace RecipeApp
{
    /// <summary>
    /// Represents a recipe consisting of ingredients and steps.
    /// </summary>
    public class Recipe
    {
        private List<Ingredient> ingredients; // List of ingredients in the recipe
        private List<Step> steps; // List of steps in the recipe

        /// <summary>
        /// Gets or sets the name of the recipe.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Delegate for calorie alert notifications.
        /// </summary>
        /// <param name="message">The alert message.</param>
        public delegate void CalorieAlert(string message);

        /// <summary>
        /// Event triggered when the total calories exceed a specified limit.
        /// </summary>
        public event CalorieAlert OnCalorieAlert;

        /// <summary>
        /// Initializes a new instance of the <see cref="Recipe"/> class.
        /// </summary>
        public Recipe()
        {
            ingredients = new List<Ingredient>();
            steps = new List<Step>();
        }

        /// <summary>
        /// Adds an ingredient to the recipe.
        /// </summary>
        /// <param name="ingredient">The ingredient to add.</param>
        public void AddIngredient(Ingredient ingredient)
        {
            ingredients.Add(ingredient);
        }

        /// <summary>
        /// Adds a step to the recipe.
        /// </summary>
        /// <param name="step">The step to add.</param>
        public void AddStep(Step step)
        {
            steps.Add(step);
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe:");
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"{i + 1}. {ingredients[i].Quantity} {ingredients[i].Unit} of {ingredients[i].Name}");
            }
            Console.WriteLine("Steps:");
            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i].Description}");
            }
        }
        /// <summary>
        /// Scales the recipe by the specified factor, adjusting all ingredient quantities accordingly.
        /// </summary>
        public void ScaleRecipe(double factor)
        {
            for (int i = 0; i < ingredientCount; i++)
            {
                ingredients[i].Quantity *= factor;
            }
        }

        public void ResetQuantities()
        {
            // Reset ingredients to original values
            // (You would need to store original quantities separately and reset them here)
        }
        /// <summary>
        /// Clears all data from the recipe, allowing for the entry of a new recipe.
        /// </summary>
        public void ClearData()
        {
            Console.WriteLine("Are you sure you want to clear all data? (Y/N)");
            string response = Console.ReadLine().ToLower();

            if (response == "y" || response == "yes")
            {
                Array.Clear(ingredients, 0, ingredientCount);
                Array.Clear(steps, 0, stepCount);
                ingredientCount = 0;
                stepCount = 0;
                Console.WriteLine("Data cleared successfully.");
            }
            else
            {
                Console.WriteLine("Operation canceled.");
            }
        }
    }
}
///////////////////////////////////////////////////////////////////////End Of File///////////////////////////////////////////////////////////////////////////////////////

