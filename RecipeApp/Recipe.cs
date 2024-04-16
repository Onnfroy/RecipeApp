using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

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

        // Commit 2: Implemented Recipe Class
        // Added the Recipe class with methods for adding ingredients, steps, and displaying the recipe.
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
    }
}

