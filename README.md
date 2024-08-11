# RecipeApp Part 3

## Instructions for Compiling and Running the Software

### Prerequisites

1.) Visual Studio 2019 or later:
- Ensure you have Visual Studio installed. You can download it from the Visual Studio Download.

2.) .NET Framework 4.8:
- Make sure the .NET Framework 4.8 is installed on your machine. You can download it from Microsoft .NET Download.

### Steps to Compile and Run:

**1.) Clone the Repository:**
- Open a terminal or command prompt and run the following command to clone the repository: git clone https://github.com/Onnfroy/RecipeApp.git _cd RecipeApp_

**2.) Open the Solution in Visual Studio:**

- Launch Visual Studio.

- Go to File > Open > Project/Solution.

- Navigate to the directory where you cloned the repository and select the RecipeApp.sln file.

**3.) Restore NuGet Packages:**

- In the Solution Explorer, right-click on the solution (RecipeApp).

- Select Restore NuGet Packages to ensure all dependencies are downloaded and configured correctly.

**4.) Build the Solution:**

- Press Ctrl+Shift+B or go to Build > Build Solution.

- Ensure there are no build errors. If there are, address them before proceeding.

**5.) Run the Application:**

- Set RecipeApp as the startup project by right-clicking on RecipeApp in the Solution Explorer and selecting Set as Startup Project.

- Press F5 or go to Debug > Start Debugging to run the application.

**6.) Running Tests:**

- Open the Test Explorer by going to Test > Test Explorer.

- Click Run All to execute all unit tests and ensure they pass.

## Application Features

1.) Enter an Unlimited Number of Recipes:
- The application allows users to enter and store an unlimited number of recipes using a List<Recipe> collection.
 
**2.) Recipe Details:**
- For each recipe, users can enter:
- A name for the recipe.
- An unlimited number of ingredients, each with a name, quantity, unit, calorie count, and food group.
- Detailed steps for preparing the recipe.
 
**3.) Display Recipes Alphabetically:**
- The application displays all stored recipes in alphabetical order by name.
- Users can select a recipe from the list to view its details.

**4.) Calorie Calculation and Alerts:**
- The application calculates the total calories of all ingredients in a recipe.
- If the total calories exceed 300, the application alerts the user with a warning message.
 
**5.) Scaling Recipes:**
- Users can scale the quantities of ingredients in a recipe by a specified factor (e.g., 0.5, 2, or 3).

**6.) Reset and Clear Data:**
- Users can reset ingredient quantities to their original values.
- All recipe data can be cleared to allow for new entries.

## User Interface

**1.) MainWindow:**
- Displays a list of all recipes.
- Buttons to add a new recipe and view the recipe menu.
- Each recipe can be expanded to show detailed information, including ingredients and steps.

**2.) AddRecipePage:**
- Form for entering a new recipe with fields for recipe name, ingredients, and steps.
- Each ingredient requires name, quantity, unit, calories, and food group.
- Button to add ingredients and finish the recipe.

**3.) CreateMenuPage:**
- Allows users to select multiple recipes to include in a menu.
- Generates a pie chart showing the percentage that each food group makes up of the total menu.

Navigation

**1.) Adding a New Recipe:**
- Click on the “Add New Recipe” button in the main window.
- Fill in the recipe details in the AddRecipePage form.
- Add each ingredient and click “Add Ingredient”.
- After adding all ingredients, click “Finish Recipe” to save the recipe.
 
**2.) Viewing and Managing Recipes:**
- The main window displays a list of all recipes.
- Click on a recipe to expand and view detailed information.
- Ingredients and steps are shown within the expander.

**3.) Generating a Menu:**
- Click on the “View Recipe Menu” button in the main window.
- Select multiple recipes from the list in the CreateMenuPage.
- Click “Generate Menu” to display a pie chart with food group distribution.

## What the App Does:

The RecipeApp is a WPF-based application that allows users to manage their recipes efficiently. Users can add, view, and manage recipes, including details about ingredients and preparation steps. The app supports scaling of ingredient quantities and provides alerts when the total calorie count of a recipe exceeds 300. It uses a modern, object-oriented approach with unit tests to ensure the reliability of its core functionalities. Additionally, the app provides a graphical user interface with a welcoming message, hover effects for buttons, and background images for an enhanced user experience.

GitHub Repository Link:

https://github.com/Onnfroy/RecipeApp.git


