using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
namespace c0730385
{
    class Program
    {
        ArrayList Beowulf;
        int counterletters = 0;
        int countSpaces = 0;
        static void Main(string[] args)
        {
            Program a = new Program();
            a.Beowulf = new ArrayList();
            a.ReadTextFiles();
        }


        public void Run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {

            using (StreamReader sr = new StreamReader("U:\\Users\\730385\\Downloads\\Beowulf.txt"))
            {
                string line;
                int counter = 0;
                int a = 0, myWord = 1;
                int averageLetterPerWord;
                ArrayList lineNumbers = new ArrayList();
                ArrayList lineNumbers2 = new ArrayList();
                int linenum = 1;
                lineNumbers.Add(22);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Beowulf.Add(line);
                    FindNumberOfBlankSpaces(line);
                    counter++;

                    //section c
                    if (line.Substring(0).Contains("Sea") || line.Substring(0).Contains("sea") && line.Substring(0).Contains("Fare") || line.Substring(0).Contains("fare"))
                    {
                        lineNumbers.Add(linenum);
                    }
                    linenum++;

                    if (line.Substring(0).Contains("fare") || line.Substring(0).Contains("Fare"))
                    {
                        if (!(line.Substring(0).Contains("war") || line.Substring(0).Contains("War")))
                        {
                            lineNumbers2.Add(linenum);
                        }

                        //section b
                        while (a <= line.Length - 1)
                        {
                            if (line[a] == ' ' || line[a] == '\n' || line[a] == '\t')
                            {
                                myWord++;
                            }
                            a++;
                        }
                        a = 0;



                    }
                    averageLetterPerWord = counterletters / countSpaces;

                    Console.WriteLine("essay count of lines" + counter);
                    Console.WriteLine("essay count of words " + myWord);
                    Console.WriteLine("The number of average letters per word is  " + averageLetterPerWord);


                    //section c
                    Console.WriteLine("The line which contains both sea and fare");
                    foreach (int i in lineNumbers)
                    {
                        Console.Write(i + " ");
                    }

                    Console.WriteLine("The line which contains Fare, but not War");
                    foreach (int i in lineNumbers2)
                    {
                        Console.Write(i + " ");
                    }
                    Console.ReadLine();
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
