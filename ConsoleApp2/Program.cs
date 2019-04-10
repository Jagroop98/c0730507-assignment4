using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        ArrayList Beowulf;
        int counterletters = 0;
        
        int countSpaces; 
        static void Main(string[] args)
        {
            Program a = new Program();
            a.Beowulf = new ArrayList();
            a.ReadTextFiles();
        }

        public void Run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {

            using (StreamReader sr = new StreamReader("U:/Users/730507/Beowulf.txt"))
            {
                string line;
                int counter = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Beowulf.Add(line);
                }
            }
        }
                public int FindNumberOfBlankSpaces(string line)
                {
                    foreach (char c in line)
                    {
                        if (char.IsLetter(c)) { counterletters++; }
                        if (char.IsWhiteSpace(c)) { countSpaces++; }
                    }
                    return countSpaces;
                }

            }

        }
    }
}