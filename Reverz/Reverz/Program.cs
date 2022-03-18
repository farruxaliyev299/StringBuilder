using System;

namespace Reverz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(indexof("lam"));

            //Yoxlamaq meqsedi ile:
            //string a = "Salam";
            //Console.WriteLine(a.IndexOf("l", 1, 2));
        }

        static int indexof(string word)
        {
            string temp = "Salam";
            int i = 0;
            bool check = false;
            for (; i < temp.Length; i++)
            {
                if (temp[i] == word[0])
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                return -1;
            }
            return i;

        }

        static int indexof(string word, int index)
        {
            string temp = "Salam";
            bool check = false;
            int i = index;
            for (; i < temp.Length; i++)
            {
                if (temp[i] == word[0])
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                return -1;
            }
            return i;
        }

        static int indexof(string word, int index, int count)
        {
            string temp = "Salam";
            bool check = false;
            int i = index;
            for (; i < index + count; i++)
            {
                if (temp[i] == word[0])
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                return -1;
            }
            return i;
        }
    }
}
