using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RecipeApp;
using NUnit.Framework.Legacy;

namespace RecipeApp.Tests
{
    [TestFixture]
    public class RecipeTests
    {
        public void AddIngredient_ShouldAddIngredientToRecipe()
        {
            // Arrange
            var recipe = new Recipe();
            var ingredient = new Ingredient { Name = "Sugar", Quantity = 2, Unit = "Cups", Calories = 300, FoodGroup = "Sweeteners" };
            //Act
            recipe.AddIngredient(ingredient);
            //Assert
            CollectionAssert.Contains(recipe.GetIngredients(), ingredient);
        }
            [Test]
            public void AddStep_ShouldAddStepToRecipe()
            {
                //Arrange
                var recipe = new Recipe();
                var step = new Step { Description = "Mix all ingredients" };

                //Act
                recipe.AddStep(step);

                //Assert
                CollectionAssert.Contains(recipe.GetSteps(), step);
            }

        [Test]
        public void CalculateTotalCalories_ShouldReturnCorrectTotal()
        {
            //Arrange
            var recipe = new Recipe();
            recipe.AddIngredient(new Ingredient { Name = "Sugar", Quantity = 1, Unit = "Cup", Calories = 300, FoodGroup = "Sweeteners" });
            recipe.AddIngredient(new Ingredient { Name = "Butter", Quantity = 0.5, Unit = "Cup", Calories = 400, FoodGroup = "Dairy" });

            //Act
            int totalCalories = recipe.CalculateTotalCalories();

            //Assert
            ClassicAssert.AreEqual(600, totalCalories);
        }
        [Test]
        public void DisplayRecipe_ShouldTriggerCalorieAlert_WhenCaloriesExceed300()
        {
            //Arrange
            var recipe = new Recipe { Name = "High Calorie Recipe"};
            bool eventTriggered = false;
            recipe.OnCalorieAlert += message =>
            {
                eventTriggered = true;
                ClassicAssert.AreEqual("Warning: Total calories exceed 300. Total: 600", message);
            };

            recipe.AddIngredient(new Ingredient { Name = "Sugar", Quantity = 1, Unit = "Cup", Calories = 200, FoodGroup = "Sweeteners" });
            recipe.AddIngredient(new Ingredient { Name = "Butter", Quantity = 0.5, Unit = "Cup", Calories = 400, FoodGroup = "Dairy" });
            
            //Act
            recipe.DisplayRecipe();

            //Assert
            ClassicAssert.IsTrue(eventTriggered, "Calorie alert was not triggered.");
        }


        }
    }
