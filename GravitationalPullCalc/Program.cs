using System;

namespace GravitationalPullCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravForce;
            double mass1;
            double mass2;
            double distance;
            string answer;

            //Methods Called
            DisplayHeader();

            //Do While Loop:
            do
            {
                Console.WriteLine("\n\nCalculation Data:");

                //Ask User for mass values for object 1 and 2 
                Console.WriteLine("Enter the mass of object 1 in kilograms: ");
                mass1 = Double.Parse(System.Console.ReadLine());
                Console.WriteLine("Enter the mass of object 2 in kilograms: ");
                mass2 = Double.Parse(System.Console.ReadLine());

                //Ask User for the distance between the two objects
                Console.WriteLine("Enter the distance between the two objects in meters: ");
                distance = Double.Parse(System.Console.ReadLine());

                //Returns gravitational force to user
                gravForce = GravForce(mass1, mass2, distance);

                //Writes Gravitational Force results to the console
                DisplayGravForce(gravForce);

                //Ask user to play again
                Console.WriteLine("\n\nWould you like to do another calculation (y/n)? ");
                answer = Console.ReadLine();
            } while (answer == "y");

            //Goodbye Message
            Console.WriteLine("\n\nThank you for using the Gravity Calculator! Goodbye! :)");
        }

        //Methods

        //Class Header
        static void DisplayHeader()
        {
            Console.WriteLine("\n\nWelcome to The Gravity Calculator!\n\n");
        }

        //Calculates Gravitational Force
        static double GravForce(double mass1, double mass2, double distance)
        {
            //Variable
            double G = Math.Pow(6.67408, -11);
            double M1 = mass1;
            double M2 = mass2;
            double R = distance;

            //Calculate: Gravitational Force
            double gravForce = (G * (M1 * M2)) / Math.Pow(R, 2);

            //Return gravitational force            
            return gravForce;
        }

        //Displays Gravitation Force Calculation Results
        private static void DisplayGravForce(double gravForce)
        {
            //Variable Decleration
            double force = gravForce;

            //Display Gravitational Force Results
            Console.WriteLine("\n\n          Calculation Results");
            Console.WriteLine("\nGravitational Force between the two objects: " + gravForce + " N");
        }
    }
}
