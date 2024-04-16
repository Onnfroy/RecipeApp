using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe(10, 10); // Example: maximum of 10 ingredients and 10 steps

            // Sample input for demonstration
            recipe.AddIngredient(new Ingredient { Name = "Sugar", Quantity = 1, Unit = "tablespoon" });
            recipe.AddIngredient(new Ingredient { Name = "Flour", Quantity = 2, Unit = "cups" });

            recipe.AddStep(new Step { Description = "Mix sugar and flour together." });
            recipe.AddStep(new Step { Description = "Bake at 350°F for 30 minutes." });

            recipe.DisplayRecipe();

            // Implement further interactions with the Recipe object as needed

            Console.ReadLine();
        }
    }
}
