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
                } else
                {
                    arr[i] = names[a];
                    Console.WriteLine(names[a]);
                }

            }

        }

    }
}
