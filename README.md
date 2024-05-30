

RecipeApp Part 2

Instructions for Compiling and Running the Software

Prerequisites

	1.	Visual Studio 2019 or later:
	•	Ensure you have Visual Studio installed. You can download it from Visual Studio Download.
	2.	.NET Framework 4.8:
	•	Make sure the .NET Framework 4.8 is installed on your machine. You can download it from Microsoft .NET Download.

Steps to Compile and Run
	1.	Clone the Repository:
	•	Open a terminal or command prompt and run the following command to clone the repository:
    git clone https://github.com/Onnfroy/RecipeApp.git
    cd RecipeApp

2.	Open the Solution in Visual Studio:
	•	Launch Visual Studio.
	•	Go to File > Open > Project/Solution.
	•	Navigate to the directory where you cloned the repository and select the RecipeApp.sln file.
	3.	Restore NuGet Packages:
	•	In the Solution Explorer, right-click on the solution (RecipeApp).
	•	Select Restore NuGet Packages to ensure all dependencies are downloaded and configured correctly.
	4.	Build the Solution:
	•	Press Ctrl+Shift+B or go to Build > Build Solution.
	•	Ensure there are no build errors. If there are, address them before proceeding.
	5.	Run the Application:
	•	Set RecipeApp as the startup project by right-clicking on RecipeApp in the Solution Explorer and selecting Set as Startup Project.
	•	Press F5 or go to Debug > Start Debugging to run the application.
	6.	Running Tests:
	•	Open the Test Explorer by going to Test > Test Explorer.
	•	Click Run All to execute all unit tests and ensure they pass.

Application Features

	1.	Enter an Unlimited Number of Recipes:
	•	The application allows users to enter and store an unlimited number of recipes using a List<Recipe> collection.
	2.	Recipe Details:
	•	For each recipe, users can enter:
	•	A name for the recipe.
	•	An unlimited number of ingredients, each with a name, quantity, unit, calorie count, and food group.
	•	Detailed steps for preparing the recipe.
	3.	Display Recipes Alphabetically:
	•	The application displays all stored recipes in alphabetical order by name.
	•	Users can select a recipe from the list to view its details.
	4.	Calorie Calculation and Alerts:
	•	The application calculates the total calories of all ingredients in a recipe.
	•	If the total calories exceed 300, the application alerts the user with a warning message.
	5.	Scaling Recipes:
	•	Users can scale the quantities of ingredients in a recipe by a specified factor (e.g., 0.5, 2, or 3).
	6.	Reset and Clear Data:
	•	Users can reset ingredient quantities to their original values.
	•	All recipe data can be cleared to allow for new entries.

What the App Does:

The RecipeApp is a console-based application that allows users to manage their recipes efficiently. Users can add, view, and manage recipes, including details about ingredients and preparation steps. The app supports scaling of ingredient quantities and provides alerts when the total calorie count of a recipe exceeds 300. It uses a modern, object-oriented approach with unit tests to ensure the reliability of its core functionalities.

GitHub Repository Link:

https://github.com/Onnfroy/RecipeApp.git

Description of Changes

Based on the feedback from my lecturer, the following changes were made to the RecipeApp project:

	1.	JUnit Testing:
	•	Implemented comprehensive JUnit tests for the Recipe class to ensure the correctness of the core functionalities such as adding ingredients, calculating total calories, and triggering alerts when calories exceed a certain threshold.
	2.	Enhanced README File:
	•	Updated the README file to include detailed instructions on how to compile and run the software.
	•	Added a link to the GitHub repository for easy access.
	•	Provided a brief description of the changes made based on the lecturer’s feedback.
	3.	GitHub Repository Visibility:
	•	Made the GitHub repository public to allow easy access and collaboration.

