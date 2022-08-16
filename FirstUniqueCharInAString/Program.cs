// Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

using System;

namespace FirstUniqueCharInAString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstUniqChar("test")) ;
        }


        public static int FirstUniqChar(string s)
        {
            int answer = -1;

            for (int i = 0; i < s.Length; i++)
            {
                bool duplicated = false;
                int charCount = 0;


                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j]) 
                    { 
                        charCount++; 
                    }
                    if ( charCount > 1) 
                    {
                        duplicated = true;
                        break; 
                    }                    
                }


                if (!duplicated)
                {
                    answer = i;
                    break;
                }                    
            }

            return answer;
        }
    }
}
