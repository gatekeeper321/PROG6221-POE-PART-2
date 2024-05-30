using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//MCPETRIE-ST10263164-PROG6221POEPART2
namespace PROG6221POEPART2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool bMenu = true;

            string recipeName = "";

            Methods methods = new Methods();

            while (bMenu == true) //having while loop allows menu to redisplay when finsihed with a specific task
            {
                //Console.Clear();
                string option = Program.DisplayMenu();

                if (option == "1") // CREATE RECIPE
                {
                    Console.WriteLine(methods.CreateRecipe());
                }
                else if (option == "2") // VIEW RECIPE
                {
                    Console.WriteLine(methods.ViewAllRecipes());
                    Console.ReadKey();
                }
                else if (option == "3") // VIEW SPECIFIC RECIPE
                {
                    Console.WriteLine(methods.ViewRecipe());
                    Console.ReadKey();
                }
                else if (option == "4") // SCALE RECIPE
                {
                    Console.WriteLine(methods.ScaleRecipe());
                    Console.ReadKey();
                }
                else if (option == "5") // RESCALE RECIPE (can revert back to orignal scale by dividng scale by itself)
                {
                    Console.WriteLine(methods.RescaleRecipe());
                    Console.ReadKey();
                }
                else if (option == "6") // ERASE RECIPE
                {
                    Console.WriteLine(methods.EraseRecipe());
                    Console.ReadKey();
                }
            }
        }

        public static string DisplayMenu() //menu
        {
            string option = "";
            bool validOption = false;

            Console.Clear();

            while (validOption == false) // while loop allows code to loop until a valid input is entered
            {
                Console.WriteLine("Welcome to the Cooking Helper!\nPlease select an option below:\n1) Create a new recipe\n2) View All Recipes\n3) Search for specific recipe\n4) Scale Recipe\n5) Rescale recipe\n6) Erase Recipe\n7) EXIT");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                option = Console.ReadLine();

                if (option == "1" || option == "2" || option == "3" || option == "4" || option == "5")
                {
                    validOption = true; // ends loop once valid option is chosen
                }
                else if (option == "6")
                {
                    System.Environment.Exit(0); //https://www.c-sharpcorner.com/UploadFile/c713c3/how-to-exit-in-C-Sharp/
                }
                else
                {
                    Console.WriteLine("Invalid input... Please enter either 1,2,3 or 4");
                }
            }
            return option;
        }

    }
}
