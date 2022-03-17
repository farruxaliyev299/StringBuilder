//1.String IndexOf methodunun 3 overloading-ni 
//(1-tek string qebul eden, 2-bir string ve index qebul eden, 3-bir string , index ve count qebul eden) yazin.

using System;


namespace IndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(indexof("l", 1,2));

            //Yoxlamaq meqsedi ile:
            string a = "Salam";
            Console.WriteLine(a.IndexOf("l",1,2));
        }

        static int indexof(string word)
        {
            string temp = "Salam";
            int i = 0;
            bool check = false;
            for (; i < temp.Length; i++)
            {
                if (temp[i].ToString() == word)
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
                if (temp[i].ToString() == word)
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
                if (temp[i].ToString() == word)
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
