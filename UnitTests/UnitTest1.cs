using Microsoft.VisualStudio.TestTools.UnitTesting;
using PROG6221POEPART2;
using System.Collections.Generic;
//MCPETRIE-ST10263164-PROG6221POEPART2
namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private Methods methods; // Declares private instance of the Methods class

        [TestInitialize]
        public void Initialize()
        {
            methods = new Methods(); // Initialize the instance of the Methods class
        }

        [TestMethod]
        public void TestCalculateTotalCalories()
        {
            string recipeName = "Pancake";
            Instruction instruction = new Instruction(1, "Test Instruction"); // Creates new Instruction
            Instruction instruction2 = new Instruction(2, "Test Instruction"); // Creates new Instruction

            Ingredient ingredient = new Ingredient("Egg", "Protein", "Wholes", 1, 15); // Creates new Ingredient
            Ingredient ingredient2 = new Ingredient("Milk", "Dairy", "Cups", 2, 50); // Creates new Ingredient
            Ingredient ingredient3 = new Ingredient("Flour", "Carbohydrates", "Cups", 2, 70); // Creates new Ingredient

            List<Ingredient> ingredients = new List<Ingredient> { ingredient, ingredient2, ingredient3 };
            List<Instruction> instructions = new List<Instruction> { instruction, instruction2 };

            Recipe recipe = new Recipe(recipeName, ingredients, instructions, 1); // Creates new Recipe

            methods.AddRecipe(recipe);

            var expected = 135;

            var actual = methods.CalculateTotalCalories(recipeName);

            Assert.AreEqual(expected, actual);
        }
    }
}
