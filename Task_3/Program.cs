using System;
using System.IO;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string srcPath = "src.txt";
            string outputPath = "output.txt";
            string[] lines = LoadSrcFileLines(srcPath);
            for (int i = 0; i < lines.Length; i++)
            {
                SearchMail(ref lines[i]);
            }
            File.WriteAllLines(outputPath, lines);
        }
        static string[] LoadSrcFileLines(string path)
        {
            return File.ReadAllLines(path);
        }
        static void SearchMail(ref string src)
        {
            bool flag = false;
            string temp = string.Empty;
            for (int i = 0; i < src.Length; i++)
            {
                if ((flag == true) && (src[i] != ' '))
                {
                    temp += src[i];
                    continue;
                }
                if (src[i] == '&')
                {
                    flag = true;
                }
            }
            src = temp;
        }
    }
}
