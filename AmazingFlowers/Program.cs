using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingFlowers
{
    class Program
    // *********************************************************
    // Title Welcome to the World of Flowers
    // Application Type Framework.NET, Console Window
    // Description The purpose of my Application is to present the Amazing World of Flowers,
    // and to help the user choose their favorites.
    // Donna Curiel
    // CIT 110
    // Current Date 11-30-2018 
    // Last Modified: 12/6/2018
    // *********************************************************
    {
        static void Main(string[] args)
        {
            DisplayOpeningScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }

        /// <summary>
        /// instantiate and initialize rose the world flower
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>world flower object</returns>
        /// 

        static WorldFlower InitializeWorldFlowerRose(string name)
        {
            WorldFlower rose = new WorldFlower(name);

            rose.Name = "Rose";
            rose.Height = 36;
            rose.Annual = false;
            rose.CurrentBlossomSeason = WorldFlower.BlossomSeason.summer;
            rose.CurrentPetalColor = WorldFlower.PetalColor.red;


            return rose;
        }

        /// <summary>
        /// instantiate and initialize daisy the world flower
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>world flower object</returns>
        /// 

        static WorldFlower InitializeWorldFlowerDaisy(string name)
        {
            WorldFlower daisy = new WorldFlower(name);

            daisy.Name = "Daisy";
            daisy.Height = 48;
            daisy.Annual = false;
            daisy.CurrentBlossomSeason = WorldFlower.BlossomSeason.spring;
            daisy.CurrentPetalColor = WorldFlower.PetalColor.white;


            return daisy;
        }

        static WorldFlower InitializeWorldFlowerHibiscus(string name)
        {
            WorldFlower hibiscus = new WorldFlower(name);

            hibiscus.Name = "Hibiscus";
            hibiscus.Height = 48;
            hibiscus.Annual = false;
            hibiscus.CurrentBlossomSeason = WorldFlower.BlossomSeason.summer;
            hibiscus.CurrentPetalColor = WorldFlower.PetalColor.yellow;


            return hibiscus;
        }

        static WorldFlower InitializeWorldFlowerLavender(string name)
        {
            WorldFlower lavender = new WorldFlower(name);

            lavender.Name = "Lavender";
            lavender.Height = 24;
            lavender.Annual = false;
            lavender.CurrentBlossomSeason = WorldFlower.BlossomSeason.summer;
            lavender.CurrentPetalColor = WorldFlower.PetalColor.purple;


            return lavender;
        }
        /// <summary>
        /// display all information about a world flower
        /// </summary>
        /// <param name="worldFlower">WorldFlower object</param>
        /// 

        static void DisplayWorldFlowerInfo(List<WorldFlower> worldFlowers)
        {
            string userWorldFlowerName;

            DisplayHeader("Display World Flower Information");

            //
            // get World Flower name from user
            //
            foreach (WorldFlower worldFlower in worldFlowers)
            {
                Console.WriteLine(worldFlower.Name);
            }
            Console.WriteLine();
            Console.Write("Enter Name of the Flower you Would Like to see: ");
            userWorldFlowerName = Console.ReadLine();

            //
            // display World Flower info
            //

            bool worldFlowerFound = false;


            foreach (WorldFlower worldFlower in worldFlowers)
            {
                if (worldFlower.Name.ToUpper() == userWorldFlowerName.ToUpper())
                {
                    Console.WriteLine(worldFlower.Name);
                    Console.WriteLine("The height is " + worldFlower.Height + @"""");
                    Console.WriteLine("The blossom season is " + worldFlower.CurrentBlossomSeason);

                    Console.WriteLine("The petal color is " + worldFlower.CurrentPetalColor);
                    if (worldFlower.Annual)
                    {
                        Console.WriteLine("This flower is an Annual");
                    }
                    else
                    {
                        Console.WriteLine("This flower is not an annual, it's a perennial.");
                    }

                    worldFlowerFound = true;
                    break;
                }
            }

            if (!worldFlowerFound)
            {
                Console.WriteLine($"Unable to locate the World Flower named {userWorldFlowerName}");
            }

            DisplayContinuePrompt();
            // do while loop for validation?
        }

        static void DisplayAllWorldFlowers(List<WorldFlower> worldFlowers)
        {
            DisplayHeader("List of World Flowers");

            foreach (WorldFlower worldFlower in worldFlowers)
            {
                //Make something about the flowers
                Console.WriteLine(worldFlower.Name);


            }

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display a screen to get a new world flower from the user
        /// </summary>
        /// <param name="worldFlowers">list of WorldFlowers</param>
        /// 
        static void DisplayGetUserWorldFlower(List<WorldFlower> worldFlowers)
        {
            // create Instantiate a new world flower object's property values from user
            //
            WorldFlower userWorldFlower = new WorldFlower();
            DisplayHeader("Please add a new World Flower of your Choice ");

            //
            //get the World Flower Property Objects
            //
            Console.Write("Please Enter Name of the new Flower: ");
            userWorldFlower.Name = Console.ReadLine().ToUpper();
            Console.Write("Enter Height of new Flower: ");
            int.TryParse(Console.ReadLine(), out int height);
            userWorldFlower.Height = height;
            Console.Write("Is the new Flower an Annual?: ");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                userWorldFlower.Annual = true;
            }
            else
            {
                userWorldFlower.Annual = false;
            }

            Console.Write("Please Enter the Blossoming Season of the Flower: ");
            Enum.TryParse(Console.ReadLine(), out WorldFlower.BlossomSeason blossomSeason);
            userWorldFlower.CurrentBlossomSeason = blossomSeason;

            Console.Write("Please Enter Flower Petal Color: ");
            Enum.TryParse(Console.ReadLine(), out WorldFlower.PetalColor petalColor);
            userWorldFlower.CurrentPetalColor = petalColor;

            worldFlowers.Add(userWorldFlower);


            DisplayContinuePrompt();
        }

        static void DisplayDeleteUserWorldFlower(List<WorldFlower> worldFlowers)
        {
            string userWorldFlowerChoice;

            DisplayHeader("Delete the World Flower of Your Choice");

            //
            // get World Flower name from user
            //
            foreach (WorldFlower worldFlower in worldFlowers)
            {
                Console.WriteLine(worldFlower.Name);
            }
            Console.WriteLine();
            Console.Write("Enter Name of Flower you want to Delete: ");
            userWorldFlowerChoice = Console.ReadLine();

            //
            // delete World Flower
            // ? confirm with user to delete Flower "name" yes or no

            bool worldFlowerFound = false;

            foreach (WorldFlower worldFlower in worldFlowers)
            {
                if (worldFlower.Name.ToLower() == userWorldFlowerChoice.ToLower())
                {
                    worldFlowers.Remove(worldFlower);
                    worldFlowerFound = true;
                    break;

                }
            }
            if (!worldFlowerFound)
            {
                Console.WriteLine($"Unable to locate the Flower named {userWorldFlowerChoice}");
            }

            DisplayContinuePrompt();
        }

        static void DisplayMenu()
        {
            //
            // instantiate world flowers
            //

            WorldFlower rose;
            rose = InitializeWorldFlowerRose("rose");

            WorldFlower daisy;
            daisy = InitializeWorldFlowerDaisy("daisy");

            WorldFlower hibiscus;
            hibiscus = InitializeWorldFlowerHibiscus("hibiscus");

            WorldFlower lavender;
            lavender = InitializeWorldFlowerLavender("lavender");


            //
            // add world flowers to list
            //

            List<WorldFlower> worldFlowers = new List<WorldFlower>();
            worldFlowers.Add(rose);
            worldFlowers.Add(daisy);
            worldFlowers.Add(hibiscus);
            worldFlowers.Add(lavender);


            string menuChoice;
            bool exiting = false;

            while (!exiting)
            {
                DisplayHeader("Main Menu");

                Console.WriteLine("\tA) Display All World Flowers");
                Console.WriteLine("\tB) Display World Flower Information");
                Console.WriteLine("\tC) Display Get World Flower from User");
                Console.WriteLine("\tD) Display Delete World Flower");
                Console.WriteLine("\tE) Exit");

                Console.Write("Enter Choice:");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "A":
                    case "a":
                        DisplayAllWorldFlowers(worldFlowers);

                        break;

                    case "B":
                    case "b":
                        DisplayWorldFlowerInfo(worldFlowers);

                        break;

                    case "C":
                    case "c":

                        DisplayGetUserWorldFlower(worldFlowers);

                        break;

                    case "D":
                    case "d":

                        DisplayDeleteUserWorldFlower(worldFlowers);

                        break;

                    case "E":
                    case "e":
                        exiting = true;
                        break;
       

                    default:
                        break;
                }
            }
        }

        #region HELPER METHODS
        /// <summary>
        /// display opening screen
        /// </summary>
        static void DisplayOpeningScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tWelcome to the Wonderful World of Flowers");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tThanks for using the Wonderful World of Flowers Application.");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display header
        /// </summary>
        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }

        #endregion

    }

}
