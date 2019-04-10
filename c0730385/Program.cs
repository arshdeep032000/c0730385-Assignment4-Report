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

            using (StreamReader sr = new StreamReader("U:/Users/725866/beowulf.txt"))
            {
                string line;
                int counter = 0;
                int a = 0, myWord = 1;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Beowulf.Add(line);
                    public int FindNumberofBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;
            foreach (char c in line)
                {
                if(char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces ++; }
            }
            
            return countSpaces;
        }
    }
}
