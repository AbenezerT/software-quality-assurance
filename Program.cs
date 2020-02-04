using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbeAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;
            Console.Write("Please enter the radius of the circle in number: ");

            while (!int.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.Clear();
                Console.WriteLine("You entered an invalid input");
                Console.Write("Please enter the radius of the circle in number: ");
            }

            AbeCircle circle = new AbeCircle(radius);
            int option;


            do
            //while option is not equale to = 5
            {

                Menu();
                //validating menu inputs
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.Clear();
                    Console.WriteLine("You entered an invalid input");
                    Menu();
                }
                if (option == 1) //diplay radius
                {
                    Console.WriteLine("The radius of the circle is: " + circle.GetRadius());
                }
                else if (option == 2)//change radius
                {
                    Console.Write("Enter the new radius of the circle: ");
                   //check if the input is 
                    while ( !int.TryParse(Console.ReadLine(), out radius) || radius < 1)  
                    {
                        Console.Clear();
                        Console.WriteLine("The radius must be an integer less than one");
                        Console.Write("Please enter again: ");
                     
                    }
                    circle.SetRadius(radius);
                }
                else if (option == 3) //display circumference
                {
                    Console.WriteLine("The circumference of the circle is: " + circle.GetCircumference());
                }
                else if (option == 4)//display area
                {
                    Console.WriteLine("The area of the circle is: " + circle.GetArea());
                }
                else if (option == 5)//exit
                {
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    Console.WriteLine("Invalid option!");
                }
            } while (option != 5);
            Console.ReadLine();

        }
        //Displays menu
        static void Menu()
        {
            Console.WriteLine("1.Get Circle Radius");
            Console.WriteLine("2.Change Circle Radius");
            Console.WriteLine("3.Get Circle Circumference");
            Console.WriteLine("4.Get Circle Area");
            Console.WriteLine("5.Exit");
        }
    }
}
