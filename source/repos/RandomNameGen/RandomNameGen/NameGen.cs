using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNameGen
{
    public class NameGen
    {
        /// <summary>
        /// Selects names from array of names, number of names is specified by the user
        /// </summary>
        /// <param name="names"> Array of names to be picked </param>
        /// <param name="count"> Number of names to be picked </param>
        public void SelectName(string[] names, int count)
        {
            string[] arr = new string[count];


            for (int i = 0; i < count; ++i)
            {
                int maxValue = names.Count() - 1;
                int a = RandomNumber.Between(0, maxValue);

                if (arr.Contains(names[a]))
                {
                    //if duplicate is in array index minused by 1 so loops again until no duplicate
                    --i;
                }
                else
                {
                    arr[i] = names[a];
                    Console.WriteLine(names[a]);
                }

            }

        }

        /// <summary>
        /// Adds name to text file 
        /// 
        /// @TODO - Replace file path with your own
        /// </summary>
        /// <param name="name"> name to be added </param>
        public void AddName(string name)
        {
            File.AppendAllText(@"C:\Users\msaif\source\repos\RandomNameGen\RandomNameGen\names.txt", name);
        }

        /// <summary>
        /// Removes name from text file
        /// 
        /// @TODO - Replace file path with your own
        /// </summary>
        /// <param name="removefrom"> Array of names which holds the name user would like to remove </param>
        /// <param name="name"> Name user would like to remove </param>
        public void RemoveName(string name)
        {
            string[] remove_from = File.ReadAllLines(@"C:\Users\msaif\source\repos\RandomNameGen\RandomNameGen\names.txt");

            for(int i = remove_from.Count()-1; i>=0; i--)
            {
                if (remove_from[i].Contains(name))
                {
                    remove_from = remove_from.Where((source, index) => index != i).ToArray();
                    File.WriteAllLines(@"C:\Users\msaif\source\repos\RandomNameGen\RandomNameGen\names.txt", remove_from);
                }
            }

        }
        /// <summary>
        /// Lists all names 
        /// 
        /// @TODO - Replace file path with your own
        /// </summary>
        /// <param name="names"> Array of names to be outputted to the user </param>
        public void ListNames()
        {
            string [] names = File.ReadAllLines(@"C:\Users\msaif\source\repos\RandomNameGen\RandomNameGen\names.txt");

            foreach ( var name in names)
            {
                Console.WriteLine(name);
            }

        }

    }
}
