﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    /// <summary>
    /// Represents a recipe consisting of ingredients and steps.
    /// </summary>
    public class Recipe
    {
        /// <summary>
        /// List of ingredients in the recipe
        /// </summary>
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        /// <summary>
        /// List of steps in the recipe
        /// </summary>
        public List<Step> Steps { get; set; } = new List<Step>();

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
            Ingredients = new List<Ingredient>();
            Steps = new List<Step>();
        }

        /// <summary>
        /// Adds an ingredient to the recipe.
        /// </summary>
        /// <param name="ingredient">The ingredient to add.</param>
        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        /// <summary>
        /// Adds a step to the recipe.
        /// </summary>
        /// <param name="step">The step to add.</param>
        public void AddStep(Step step)
        {
            Steps.Add(step);
        }

        /// <summary>
        /// Displays the recipe details.
        /// </summary>
        public void DisplayRecipe()
        {
            Console.WriteLine($"Recipe: {Name}");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name} ({ingredient.Calories} calories)");
            }

            Console.WriteLine("Steps:");
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i].Description}");
            }

            int totalCalories = CalculateTotalCalories();
            Console.WriteLine($"Total Calories: {totalCalories}");

            if (totalCalories > 300)
            {
                OnCalorieAlert?.Invoke($"Warning: Total calories exceed 300. Total: {totalCalories}");
            }
        }

        /// <summary>
        /// Scales the recipe by the specified factor.
        /// </summary>
        /// <param name="factor">The scaling factor.</param>
        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
            Console.WriteLine("Recipe scaled successfully.");
        }

        /// <summary>
        /// Resets the quantities of ingredients to their original values.
        /// </summary>
        public void ResetQuantities()
        {
            // Assuming you store original quantities separately if needed
        }

        /// <summary>
        /// Clears all data from the recipe.
        /// </summary>
        public void ClearData()
        {
            Ingredients.Clear();
            Steps.Clear();
            Name = string.Empty;
            Console.WriteLine("Data cleared successfully.");
        }

        /// <summary>
        /// Calculates the total calories of the recipe.
        /// </summary>
        /// <returns>The total calories.</returns>
        public int CalculateTotalCalories()
        {
            int totalCalories = 0;
            foreach (var ingredient in Ingredients)
            {
                totalCalories += ingredient.Calories;
            }
            return totalCalories;
        }

        /// <summary>
        /// Gets the list of ingredients.
        /// </summary>
        /// <returns>A list of ingredients.</returns>
        public List<Ingredient> GetIngredients() => Ingredients;

        /// <summary>
        /// Gets the list of steps.
        /// </summary>
        /// <returns>A list of steps.</returns>
        public List<Step> GetSteps() => Steps;
        public string GetRecipeDetails()
        {
            StringBuilder details = new StringBuilder();
            details.AppendLine($"Recipe: {Name}");
            details.AppendLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                details.AppendLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name} ({ingredient.Calories} calories)");
            }

            details.AppendLine("Steps:");
            for (int i = 0; i < Steps.Count; i++)
            {
                details.AppendLine($"{i + 1}. {Steps[i].Description}");
            }

            int totalCalories = CalculateTotalCalories();
            details.AppendLine($"Total Calories: {totalCalories}");

            if (totalCalories > 300)
            {
                details.AppendLine($"Warning: Total calories exceed 300. Total: {totalCalories}");
            }

            return details.ToString();
        }
    }
}

//--------------------------------------------------------EOF--------------------------------------------------------------------------------//
