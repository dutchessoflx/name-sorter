using System;
using System.Collections.Generic;
using System.IO;

namespace name_sorter
{
    class Program
    {
        public Int32 Compare(string[] n1, string[] n2)
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            var listAllNames = new List<string[]>();
            var sortedNames = new List<string>();
            Console.WriteLine(args.Length);
            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect Arguments given");
                return;
            }

                      

            var lines = File.ReadAllLines(args[0]);

            for (int i = 0; i < lines.Length; i++)
            {
                var fullName = lines[i].Split(' ');         
                listAllNames.Add(fullName);

            }

            listAllNames.Sort((n1, n2) =>
            {
                if (n1[n1.Length - 1] == n2[n2.Length - 1])
                {
                   return String.Join(" ", n1).CompareTo(String.Join(" ", n2));
                    
                }
                else
                {
                    return n1[n1.Length - 1].CompareTo(n2[n2.Length - 1]);

                }
            });



            var allNamesLength = listAllNames.ToArray().Length;
            for (int j = 0; j < allNamesLength; j++)
            {
                var sortedFullName = String.Join(" ", listAllNames[j]);
                sortedNames.Add(sortedFullName);
            }
            File.WriteAllLines("sorted-names-list.txt", sortedNames);
            var sortedNamesObject = String.Join("\n", sortedNames);
            Console.WriteLine(sortedNamesObject);


            /*int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\Nala\Documents\SEI\Coding Challenges\GlobalX\name-sorter\name-sorter\TextFile1.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine("line", line);
                System.Console.WriteLine("file", file);

                List<string> nameList = new List<string>();
                nameList.Add(line);
                Console.WriteLine(nameList, "namelist");
                counter++;
               
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.
            System.Console.ReadLine();

            var names = new List<string>
            {"tom", "harry", "anna" };
           

        names.Sort((n1, n2) => n1.Split(" ")[1].CompareTo(n2.Split(" ")[1]));
            Console.WriteLine(string.Join(",", names));

        }

    }*/
        }
    }
}
