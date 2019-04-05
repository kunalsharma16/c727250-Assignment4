using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c727250_Assignment4
{
    class Program
    {
       ArrayList Beowulf;

        public char C { get; private set; }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
        }

        public void Run()
        {
            this.ReadTextFiles();
        }

        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader(@"U:\Users\727250\kunalsharma.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln =file.ReadLine()) !=null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }
       
        public int FindNumberofBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++;}
                if (char.IsWhiteSpace(C)) { countSpaces++; }
            }
            return countSpaces;

        }
    }
}
