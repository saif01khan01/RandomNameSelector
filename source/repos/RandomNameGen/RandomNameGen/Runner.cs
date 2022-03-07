using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNameGen
{
    public class Runner
    {

        static public void Main(string[] args)
        {
            NameGen test = new NameGen();

            Console.WriteLine("Choose one of the following operations (Enter the letter associated with the operation)" + Environment.NewLine
                + "A. Select Random Names" + Environment.NewLine
                + "B. Add name to list" + Environment.NewLine
                + "C. Remove name from list" + Environment.NewLine
                + "D. List all names" + Environment.NewLine);

            string operation = Console.ReadLine();

            operation.ToUpper();

            // Validation of user input
            switch (operation)
            {
                case "A":
                    //Converts each line from text file to array element
                    string[] names = File.ReadAllLines(@"C:\Users\msaif\source\repos\RandomNameGen\RandomNameGen\names.txt");

                    Console.WriteLine("How many names would you like to select");

                    string temp;
                    temp = Console.ReadLine();
                    int count = Int32.Parse(temp);

                    //if user chooses number of names larger than list will fail
                    if (count > names.Count())
                    {
                        Console.WriteLine("The Number of names you would like to pick is greater than the number of names in the list try again");
                    }
                    else
                    {
                        test.SelectName(names, count);
                    }
                    break;

                case "B":
                    Console.WriteLine("Please enter the name you would like to add");
                    string name_to_add = Console.ReadLine();
                    test.AddName(name_to_add);
                    break;

                case "C":
                    Console.WriteLine("Please enter the name you would like to remove");
                    string name_to_remove = Console.ReadLine();

                    test.RemoveName(name_to_remove);
                    break;

                case "D":
                    test.ListNames();
                    break;
            }




            


        }
    }
}
