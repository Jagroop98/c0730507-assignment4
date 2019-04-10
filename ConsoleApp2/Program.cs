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
        int linenumber = 1;
        int linecount = 0;
        ArrayList lineNumbers1 = new ArrayList();
        int countSpaces;
        

        static void Main(string[] args)
        {
            Program a = new Program();
            a.Beowulf = new ArrayList();
            a.countWords();
            a.Foundnumbers();
            
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

        public void lineCount()
        {
            string line;
            TextReader reader = new StreamReader("U:/Users/730507/Beowulf.txt");
            while ((line = reader.ReadLine()) != null)
            {
                linecount++;
            }
            reader.Close();

            Console.WriteLine(linecount);

        }
        public void countWords()
        {
            StreamReader pr = new StreamReader("U:/Users/730507/Beowulf.txt");
            int counter = 0;
            string delim = ",";
            string[] fields = null;
            string line = null;
            while (!pr.EndOfStream)
            {
                line = pr.ReadLine();
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                counter += fields.Length;

            }

            pr.Close();
            Console.WriteLine("the number of words in the text file is {0}", counter);


        }

        public void Foundnumbers()
        {
            using (StreamReader file = new StreamReader("U:/Users/730507/Beowulf.txt"))

            {
                int counter = 0;

                int number = 0;

                string line;

                while ((line = file.ReadLine()) != null)

                {

                    if (line.Contains("Sea") && line.Contains("Fare") || line.Contains("sea") && line.Contains("fare"))

                    {

                        int x = counter - 1;

                        number++;

                    }

                    counter++;

                }

                Console.WriteLine($"The number of lines that contains *Sea* and *Fare* are {number}");

                file.Close();

            }

        }
        public void Averagenumber()
        {

            using (StreamReader sr = new StreamReader("U:/Users/730507/Beowulf.txt"))
            {
                string line;
                int counter = 0;
                int b = 0, myWord = 1;
                int averageLetterPerWord;
                int counterletters = 0;
                int countspaces = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Beowulf.Add(line);
                    FindNumberOfBlankSpaces(line);
                    counter++;

                    while (b <= line.Length - 1)
                    {
                        if (line[b] == ' ' || line[b] == '\n' || line[b] == '\t')
                        {
                            myWord++;
                        }
                        b++;
                    }
                    b = 0;

                }

                averageLetterPerWord = counterletters / countspaces;

                Console.WriteLine("\n\n\n\n********************************\nThe number of lines in the paragraph is " + counter);
                Console.WriteLine("The number of words in paragraph is " + myWord);
                Console.WriteLine("The number of average letters per word is " + averageLetterPerWord);
                Console.ReadLine();






                // SECTION D
                if (line.Substring(0).Contains("fare") || line.Substring(0).Contains("Fare"))
                {
                    if (!(line.Substring(0).Contains("war") || line.Substring(0).Contains("War")))
                    {
                        lineNumbers1.Add(linenumber);
                    }
                    Console.WriteLine(linenumber);

                }
            }
        }



    }

}
    
