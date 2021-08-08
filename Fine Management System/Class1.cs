using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fine_Management_System
{
    class Class1
    {
        static List<char> chars = new List<char>();
        
        public static string password()
        {
            addchars(ref chars);
            string pass = generatePassword(8);
            return pass;
        }
        
        static string generatePassword(int length)
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            int j = 0;

            while(j < length)
            {
                sb.Append(chars[rnd.Next(0, chars.Count)]);
                j++;
            }
            return sb.ToString();
        }
        static void addchars(ref List<char> chars)
        {
            for(char c = 'a'; c <= 'z'; c++)
            {
                chars.Add(c);
            }
            for (char c = 'A'; c <= 'Z'; c++)
            {
                chars.Add(c);
            }
            for (char c = '0'; c <= '9'; c++)
            {
                chars.Add(c);
            }
            for (char c = '!'; c <= '?'; c++)
            {
                chars.Add(c);
            }
        }
    }
}
