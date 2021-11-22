using System;
using System.IO;
using System.Linq;


namespace OOP_Homework_2
{
    static class Files
    {
        public static void CreateFail(string file)
        {
            if (!File.Exists(file))
            {
                Random rdm = new Random();
                string s = null;
                string b = null;
                for (int i = 0; i < 10; i++)
                {
                    for (int k = 0; k < 16; k++)
                    {
                        if (k == 0)
                        {
                            int c;
                            c = rdm.Next(1, 10);
                            s += c.ToString();
                        }
                        else
                        {
                            int c;
                            c = rdm.Next(0, 10);
                            s += c.ToString();
                        }
                    }
                    b = $"\n{i + 1}: {s} ";
                    File.AppendAllText(file, b);
                    s = null;
                    b = null;
                }
            }
        }
        public static void DisplayFile(string file)
        {
            Console.WriteLine(File.ReadAllText(file));
        }
        public static string SearchInFile(string file, string numbsearch)
        {
            var readfile = File.ReadAllText(file);
            string search = $"\n{numbsearch}:";
            string[] fileArray = readfile.Split(' ').ToArray();
            int numb = 0;
            for (int i = 0; i < fileArray.Length; i++)
            {
                if (fileArray[i] == search)
                {
                    numb = i + 1;
                    break;
                }
            }
            return fileArray[numb];
        }

    }
}
