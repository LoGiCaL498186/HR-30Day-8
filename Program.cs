using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        try
        {


            Dictionary<string, string> phoneContacts = new Dictionary<string, string>();

            int NumberOfEntries = int.Parse(Console.ReadLine());
            string tempLine = string.Empty;

            while ((tempLine = Console.ReadLine()).Contains(" ") && phoneContacts.Count <= NumberOfEntries)
            {
                phoneContacts.Add(tempLine.Split(' ')[0].Trim(), tempLine.Split(' ')[1].Trim());
            }

            string line = string.Empty;
            List<string> queries = new List<string>();

            do
            {
                if (!string.IsNullOrEmpty(tempLine))
                {
                    switch (phoneContacts.TryGetValue(tempLine, out line))
                    {
                        case true:
                            queries.Add(string.Format("{0}={1}", tempLine, line));
                            break;
                        default:
                            {
                                queries.Add("Not found");
                                break;
                            }
                    }
                }



            } while (!string.IsNullOrEmpty((tempLine = Console.ReadLine())));

            string[] outputs = new string[queries.Count];
            queries.CopyTo(outputs);

            //now print output
            using (TextWriter txtWtr = Console.Out)
            {
                for (int i = 0; i < outputs.Length; i++)
                {

                    txtWtr.WriteLine(outputs[i].Trim());
                }
            }

        }
        catch(Exception ex)
        {
            throw ex;
        }

        Console.ReadKey();

    }
}


