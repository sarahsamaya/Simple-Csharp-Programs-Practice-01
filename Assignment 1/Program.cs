using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        enum Ticket
        {
            PURPLE = 50,
            GREEN = 80,
            BLUE = 100
        }

        public static void Main(string[] args)
        {
            //Problem5 - choose wich program runs

            /*Date: FEB 02 Author: Sarah Rodrigues
			  Objective:allows the user to choose which program to run. The menu choice is printed to the user*/

            //declaring variable
            String program1 = "Program 1: Distance Speed Problem";
            String program2 = "Program 2: How much is My basketball fantasy costing me?";
            String program3 = "Program 3: Cubester";
            String program4 = "Program 4: Am I Prime?";

            bool exitProgram = false;

            do
            {
                Console.WriteLine("\n" + "***ASSIGNMENT 1***");
                Console.WriteLine("Sarah Samaya B. Rodrigues: 8569444: PROG8050, 20W, Sec1" + "\n");

                Console.WriteLine("Select an option from 1 to 4 bellow or 5 to exit:" + "\n");
                Console.WriteLine("1 ==> {0}", program1);
                Console.WriteLine("2 ==> {0}", program2);
                Console.WriteLine("3 ==> {0}", program3);
                Console.WriteLine("4 ==> {0}", program4);
                Console.WriteLine("5 ==> Exit");



                int selectedProgram = int.Parse(Console.ReadLine());

                switch (selectedProgram)
                {

                    case 1:
                        //Problem 1 - Find the time with speed and distance
                        Console.WriteLine("You selected the {0}" + "\n", program1);
                        SpeedDistanceTime();

                        break;
                    case 2:
                        //Problem 2 - Return the total and averange spent with tickets
                        Console.WriteLine("You selected the {0}" + "\n", program2);
                        AmountSpentWithTickets();

                        break;
                    case 3:
                        //Problem 3 - Calclate the Cube of the number
                        Console.WriteLine("You selected the {0}" + "\n", program3);
                        CubeOfTheNubmer();

                        break;
                    case 4:
                        //Problem 4 - Prime odd or Even composite
                        Console.WriteLine("You selected the {0}" + "\n", program4);
                        DisplayEverOrOdd();

                        break;
                    case 5:
                        exitProgram = true;
                        Console.WriteLine("Program ended!");

                        break;
                    default:
                        Console.WriteLine("This option is invalid! Select an option from 1 to 4 bellow or 5 to exit:" + "\n");
                        break;

                }
            } while (!exitProgram);

        }

        static void SpeedDistanceTime()
        {
            /*Date: FEB 02 Author: Sarah Rodrigues
			Objective:Calculate the hours and minutes it would take to make a trip using a determined speed(mph)*/

            //declaring variables
            double speedMph;
            double distanceMile;

            Console.WriteLine("*******PROBLEM 1:TIME OF TRAVEL*******" + "\n");

            Console.WriteLine("Enter your speed in mile/hour:");

            while (true)
            {   //Validating Mph
                if (double.TryParse(Console.ReadLine(), out speedMph))
                {

                    Console.WriteLine("Your sepped in mph is {0}.", speedMph);
                }
                else
                {
                    Console.WriteLine("This option is invalid! Enter your speed in mile/hour.");
                    continue;

                }
                
                Console.WriteLine("Enter the distance you needs to travel in miles:");
                //Validating distance
                if (double.TryParse(Console.ReadLine(), out distanceMile))
                {
                    Console.WriteLine("The needed miles is {0}.", distanceMile);
                }
                else
                {
                    Console.WriteLine("This option is invalid! Enter the distance you needs to travel in miles.");
                    continue;
                }
                break;
            }

            //calculating time
            if (((double)speedMph > 0 && !speedMph.Equals(null)) && ((double)distanceMile > 0 && !distanceMile.Equals(null)))
            { 
                //time = distance/speed
                int hour = (int)(distanceMile / speedMph);
                int minutes = (int)(distanceMile % speedMph);
                Console.WriteLine("\n" + "At {0} mph, it will take {1} hour and {2} minutes to travel {3} miles.", speedMph, hour, minutes, distanceMile);
            }

        }

        static void AmountSpentWithTickets()
        {
            /*Date: FEB 02 Author: Sarah Rodrigues
             *Objective: It calculates the total amount spent with tickets sand the average price
             * of watch the games*/


            //declaring variables
            int seatPurpleCont = 0;
            int seatGreenCont = 0;
            int seatBlueCont = 0;

            int total = 0;
            int average = 0;

            int selectedOption = 0;

            bool exit = false;

            //Desplaying informations of the types of seats
            Console.WriteLine("*******PROBLEM 2: RAPTORS GAME*******" + "\n");
            Console.WriteLine("Welcome to season 2020, these are available seats:");

            do
            {

                Console.WriteLine("Select an option from 1 to 3 below or 4 to exit: " + "\n");


                Console.WriteLine("1 ==> {0}, {1}.", Ticket.PURPLE, (int)Ticket.PURPLE);
                Console.WriteLine("2 ==> {0}, {1}.", Ticket.GREEN, (int)Ticket.GREEN);
                Console.WriteLine("3 ==> {0}, {1}.", Ticket.BLUE, (int)Ticket.BLUE);
                Console.WriteLine("4 ==> Exit");


                if (!int.TryParse(Console.ReadLine(), out selectedOption))
                {
                    Console.WriteLine("This option is invalid! Select an option from 1 to 3 or 4 to exit:");
                    continue;
                }
                else
                {
                    //Creating a menu to select the type of ticket
                    switch (selectedOption)
                    {

                        case 1:

                            Console.WriteLine("How many tickets of type {0} did you buy?", Ticket.PURPLE);

                            int prm1 = 0;

                            if (int.TryParse(Console.ReadLine(), out prm1))
                            {
                                seatPurpleCont = seatPurpleCont + prm1;
                                Console.WriteLine("You bought {0} tickets of type {1}" + "\n", seatPurpleCont, Ticket.PURPLE);
                            }
                            else
                            {
                                Console.WriteLine("This option is invalid! Enter only with numbers:");
                            }

                            break;
                        case 2:
                            Console.WriteLine("How many tickets of type {0} did you buy?", Ticket.GREEN);

                            int prm2 = 0;

                            if (int.TryParse(Console.ReadLine(), out prm2))
                            {
                                seatGreenCont = seatGreenCont + prm2;
                                Console.WriteLine("You bought {0} tickets of type {1}" + "\n", seatGreenCont, Ticket.GREEN);
                            }
                            else
                            {
                                Console.WriteLine("This option is invalid! Enter only with numbers");
                            }
                            break;
                        case 3:
                            Console.WriteLine("How many tickets of type {0} did you buy?", Ticket.BLUE);

                            int prm3 = 0;

                            if (int.TryParse(Console.ReadLine(), out prm3))
                            {
                                seatBlueCont = seatBlueCont + prm3;
                                Console.WriteLine("You bought {0} tickets of type {1}" + "\n", seatBlueCont, Ticket.BLUE);
                            }
                            else
                            {
                                Console.WriteLine("This option is invalid! Enter only with numbers");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Thank for you purchase.");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("This option is invalid! Select an option from 1 to 3 or 4 to exit");
                            break;

                    }
                    //Calculating the total spent with the tickets
                    total = TotalPriceTicket(seatPurpleCont, seatGreenCont, seatBlueCont);

                    //Calculating the averange price of the ticket
                    average = AveragePriceTicket(total, seatPurpleCont, seatGreenCont, seatBlueCont);

                    Console.Write("\n" + "You spent a total of ${0} and the averange price of watching the game is ${1}." + "\n", total, average);
                }


            } while (!exit);


        }

        static void CubeOfTheNubmer()
        {

            /*Date: FEB 02 Author: Sarah Rodrigues
            Objective: It diplays the cube of the sequence of numbers*/

            //declaring variables
            int cube = 3;
            int term = 0;

            Console.WriteLine("*******PROBLEM 3: CALCULATE CUBE*******" + "\n");

            Console.WriteLine("Enter with the number of terms to calculate the cube:");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out term))
                {

                    for (int number = 1; number <= term; number++)
                    {

                        //calculating the Cube
                        Console.WriteLine($"{number}^{cube} = {(long)Math.Pow(number, cube):N0}");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("This option is invalid!" + "\n" + "Enter with the number of terms to calculate the cube:");
                    continue;
                }
            }

        }

        static void DisplayEverOrOdd()
        {

            /*Date: FEB 02 Author: Sarah Rodrigues
            Objective: It checks weather the number is is even or odd, and if it is prime or not*/

            Console.WriteLine("*******PROBLEM 4: EVEN OR ODD*******" + "\n");

            Console.WriteLine("Enter with a number bigger than 2 to find if it is even or odd:");
            int numberEvenOrOdd;
            while (true)
            {
                if ((int.TryParse(Console.ReadLine(), out numberEvenOrOdd)) && numberEvenOrOdd > 2)
                {
                    //check if the number is even
                    if (numberEvenOrOdd % 2 == 0)
                    {
                        Console.WriteLine("The number {0} is a even composite", numberEvenOrOdd);
                    }
                    else
                    {   //if the number is odd, check if it is prime
                        if (CheckIfOddIsPrime(numberEvenOrOdd))
                        {
                            Console.WriteLine("The number {0} is a odd prime", numberEvenOrOdd);

                        }
                        else
                        {
                            Console.WriteLine("The number {0} is a odd, but it is not prime", numberEvenOrOdd);

                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("This option is invalid!" + "\n" + "Enter with a number bigger than 2 to find if it is even or odd:");
                    continue;
                }
            }


        }



        /****FUNCTIONS***/

        static bool CheckIfOddIsPrime(int nOdd)
        {
            /*Date: FEB 02 Author: Sarah Rodrigues
            *Function Objective: It receives a int number, check if it is prime or not,
            * and return true if it is prime */

            //declaring variables
            int i;
            int cont = 0;
            bool prime = true;

            // decrease i until find a divisor for nOdd
            for (i = 2; i < nOdd; i++)
            {
                //If to check if there is a divisor for nOdd
                if ((nOdd % i) == 0)
                {

                    cont++;

                    break;
                }
            }
            if (cont == 0)
            {
                //if nOdd found a divisor, it is prime
                prime = true;

            }
            else
            {
                //if nOdd didn't find a divisor, it isn't prime
                prime = false;

            }

            return prime;
        }
        static int TotalPriceTicket(int seatPurpleCont, int seatGreenCont, int seatBlueCont)
        {
            /*Date: FEB 02 Author: Sarah Rodrigues
            *Function Objective: It calculate the total spent with tickets,
            * and return a  int */

            int total = ((seatPurpleCont * (int)Ticket.PURPLE)) + ((seatGreenCont * (int)Ticket.GREEN)) + ((seatBlueCont * (int)Ticket.BLUE));

            return total;
        }

        static int AveragePriceTicket(int total, int seatPurpleCont, int seatGreenCont, int seatBlueCont)
        {
            /*Date: FEB 02 Author: Sarah Rodrigues
            *Function Objective: It average sepent per tickets,
            * and return a  int */
            int average = total / (seatPurpleCont + seatGreenCont + seatBlueCont);

            return average;

        }

    }
}