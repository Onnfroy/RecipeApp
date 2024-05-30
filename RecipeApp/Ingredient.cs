using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    /// <summary>
    /// Represents an ingredient in a recipe.
    /// </summary>
    public class Ingredient
    {
        /// <summary>
        /// Gets or sets the name of the ingredient.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the ingredient.
        /// </summary>
        public double Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit of measurement for the ingredient.
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets the calorie count of the ingredient.
        /// </summary>
        public int Calories { get; set; }

        /// <summary>
        /// Gets or sets the food group of the ingredient.
        /// </summary>
        public string FoodGroup { get; set; }
    }
}
///////////////////////////////////////////////////////////////////////End Of File///////////////////////////////////////////////////////////////////////////////////////
