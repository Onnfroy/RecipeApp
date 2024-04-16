using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    class Recipe
    {
        private Ingredient[] ingredients;
        private Step[] steps;
        private int ingredientCount;
        private int stepCount;

        public Recipe(int maxIngredients, int maxSteps)
        {
            ingredients = new Ingredient[maxIngredients];
            steps = new Step[maxSteps];
            ingredientCount = 0;
            stepCount = 0;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            if (ingredientCount < ingredients.Length)
            {
                ingredients[ingredientCount] = ingredient;
                ingredientCount++;
            }
            else
            {
                Console.WriteLine("Cannot add more ingredients. Array is full.");
            }
        }

        public void AddStep(Step step)
        {
            if (stepCount < steps.Length)
            {
                steps[stepCount] = step;
                stepCount++;
            }
            else
            {
                Console.WriteLine("Cannot add more steps. Array is full.");
            }
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

