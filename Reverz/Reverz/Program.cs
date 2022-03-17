//2.Bir string qebul edib, onu sözbəsöz reverse edən metod yazın. Məs: input - "Ibrahim yaxşı oğlandı" , output - "miharbİ ışxay ıdnalğo"
//String Builder den istifade eleyib yazdim.

using System;
using System.Text;

namespace Reverz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sb ="Muellim gece-gece yazmisam , aglima basqa yol gelmedi";
            Console.WriteLine(Reverse(sb));
        }

        static string Reverse(string text)
        {
            StringBuilder text1 = new StringBuilder();
            int i = 0;
            int tempI = 0;
            int busStop;

            
            Eligible:
                
                while (text[i].ToString() != " " )
                {
                    if (i == text.Length - 1)
                    {
                        
                        break;
                    }
                    i++;
                }
            busStop = tempI;
            tempI = i;
            
            while (i > busStop)
            {
                if(i== text.Length - 1)
                {
                    text1.Append(text[i]);
                    i--;
                    
                }
                else
                {
                    i--;
                }
                
                text1.Append(text[i]);
            }
            text1.Append(" ");
            

                
                i = tempI+1;

            if (i != text.Length)
            {
                goto Eligible;
            }



            return text1.ToString();
        }
    }
}
