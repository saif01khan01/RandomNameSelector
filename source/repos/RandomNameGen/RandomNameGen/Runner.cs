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

            


        }
    }
}
