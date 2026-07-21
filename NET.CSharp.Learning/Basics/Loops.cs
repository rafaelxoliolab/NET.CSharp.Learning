using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.CSharp.Learning.Basics
{
    internal class Loops
    {
        void DoWhile()
        {
            Random random = new Random();
            int current = 0;

            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7);
        }

        /* Battle Challenge
         In some role playing games, the player's character battles non-player characters, which are usually monsters or the "bad guys". 
        Sometimes, a battle consists of each character generating a random value using dice and that value is subtracted from the opponent's health score. 
        Once either character's health reaches zero, they lose the game.

        In this challenge, we boil down that interaction to its essence. A hero and a monster start with the same health score. During the hero's turn, 
        they generate a random value that is subtracted from the monster's health. If the monster's health is greater than zero, they take their turn and attack the hero. 
        As long as both the hero and the monster have health greater than zero, the battle resumes.

        You must use either the do-while statement or the while statement as an outer game loop.
        The hero and the monster start with 10 health points.
        All attacks are a value between 1 and 10.
        The hero attacks first.
        Print the amount of health the monster lost and their remaining health.
        If the monster's health is greater than 0, it can attack the hero.
        Print the amount of health the hero lost and their remaining health.
        Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
        Print the winner.
         */
        void battleChallenge()
        {
            int hero = 10;
            int monster = 10;

            Random dice = new Random();

            do
            {
                int roll = dice.Next(1, 11);
                monster -= roll;
                Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

                if (monster <= 0) continue;

                roll = dice.Next(1, 11);
                hero -= roll;
                Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

            } while (hero > 0 && monster > 0);

            Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
        }

        void validEntry()
        {
            string? readResult;
            bool validEntry = false;
            Console.WriteLine("Enter a string containing at least three characters:");
            do
            {
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    if (readResult.Length >= 3)
                    {
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Your input is invalid, please try again.");
                    }
                }
            } while (validEntry == false);
        }

        void validInteger()
        {
            string? readResult;
            string valueEntered = "";
            int numValue = 0;
            bool validNumber = false;

            Console.WriteLine("Enter an integer value between 5 and 10");

            do
            {
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    valueEntered = readResult;
                }

                validNumber = int.TryParse(valueEntered, out numValue);

                if (validNumber == true)
                {
                    if (numValue <= 5 || numValue >= 10)
                    {
                        validNumber = false;
                        Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you entered an invalid number, please try again");
                }
            } while (validNumber == false);

            Console.WriteLine($"Your input value ({numValue}) has been accepted.");

            readResult = Console.ReadLine();
        }

        void validText()
        {
            string? readResult;
            string roleName = "";
            bool validEntry = false;

            do
            {
                Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    roleName = readResult.Trim();
                }

                if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
                {
                    validEntry = true;
                }
                else
                {
                    Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
                }

            } while (validEntry == false);

            Console.WriteLine($"Your input value ({roleName}) has been accepted.");
            readResult = Console.ReadLine();
        }

        void validDisplaySubstrings()
        {
            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            int stringsCount = myStrings.Length;

            string myString = "";
            int periodLocation = 0;

            for (int i = 0; i < stringsCount; i++)
            {
                myString = myStrings[i];
                periodLocation = myString.IndexOf(".");

                string mySentence;

                // extract sentences from each string and display them one at a time
                while (periodLocation != -1)
                {

                    // first sentence is the string value to the left of the period location
                    mySentence = myString.Remove(periodLocation);

                    // the remainder of myString is the string value to the right of the location
                    myString = myString.Substring(periodLocation + 1);

                    // remove any leading white-space from myString
                    myString = myString.TrimStart();

                    // update the comma location and increment the counter
                    periodLocation = myString.IndexOf(".");

                    Console.WriteLine(mySentence);
                }

                mySentence = myString.Trim();
                Console.WriteLine(mySentence);
            }

            /*
             You're working on the Contoso Pets application, an application that helps place pets in new homes. The specifications for your application are:

Create a C# console application.

Store application data in a multidimensional string array named ourAnimals.

The ourAnimals array includes the following "pet characteristics" for each animal:

Pet ID #.
Pet species (cat or dog).
Pet age (years).
A description of the pet's physical condition/characteristics.
A description of the pet's personality.
The pet's nickname.
Implement a sample dataset that represents dogs and cats currently in your care.

Display menu options to access the main features of the application.

The main features enable the following tasks:

List the pet information for all animals in the ourAnimals array.

Add new animals to the ourAnimals array. The following conditions apply:

The pet species (dog or cat) must be entered when a new animal is added to the ourAnimals array.
A pet ID must be programmatically generated when a new animal is added to the ourAnimals array.
Some physical characteristics for a pet may be unknown until a veterinarian's examination. For example: age, breed, and neutered/spayed status.
An animal's nickname and personality may be unknown when a pet first arrives.
Ensure animal ages and physical descriptions are complete. This may be required after a veterinarian's examination.

Ensure animal nicknames and personality descriptions are complete (this action can occur after the team gets to know a pet).

Edit an animal’s age (if a pet's birth date is known and the pet has a birthday while in our care).

Edit an animal’s personality description (a pet may behave differently after spending more time in our care).

Display all cats that meet user specified physical characteristics.

Display all dogs that meet user specified physical characteristics.

An initial version of the application has already been completed. The Starter code project for this Guided project module includes a Program.cs file that provides the following code features:

The code declares variables used to collect and process pet data and menu item selections.

The code declares the ourAnimals array.

The code uses a for loop around an if-elseif-else construct to populate the ourAnimals array with a sample dataset.

The code displays the following main menu options for user selection:

List all of our current pet information.
Assign values to the ourAnimals array fields.
Ensure animal ages and physical descriptions are complete.
Ensure animal nicknames and personality descriptions are complete.
Edit an animal’s age.
Edit an animal’s personality description.
Display all cats with a specified characteristic.
Display all dogs with a specified characteristic.
Enter menu item selection or type "Exit" to exit the program

The code reads the user's menu item selection and displays a message echoing their selection.

Your goal is to develop the features that implement the first two menu options. To achieve this goal, you'll complete the following tasks:

Update the code that's used to create the sample data for the app.
Construct a loop around the main menu and create a selection statement that establishes a code branch for each menu option.
Write the code to display all ourAnimals array data (menu option 1).
Build a loop for entering new ourAnimals array data (menu option 2 - part 1).
Write code to read and save new ourAnimals array data (menu option 2 - part 2).
You'll test your application at each stage of the development process.
             */
            void petSample()
            {
                string[][] jaggedArray = new string[][]
    {
        new string[] { "one1", "two1", "three1", "four1", "five1", "six1" },
        new string[] { "one2", "two2", "three2", "four2", "five2", "six2" },
        new string[] { "one3", "two3", "three3", "four3", "five3", "six3" },
        new string[] { "one4", "two4", "three4", "four4", "five4", "six4" },
        new string[] { "one5", "two5", "three5", "four5", "five5", "six5" },
        new string[] { "one6", "two6", "three6", "four6", "five6", "six6" },
        new string[] { "one7", "two7", "three7", "four7", "five7", "six7" },
        new string[] { "one8", "two8", "three8", "four8", "five8", "six8" }
    };

                foreach (string[] array in jaggedArray)
                {
                    foreach (string value in array)
                    {
                        Console.WriteLine(value);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
