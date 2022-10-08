using System;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            int count = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == 4)
                {
                    count++;
                    
                }

            }
            int k = 0;
            string[] Letters = new string[count];
            for (int j = 0; j < strings.Length; j++)
            {
                if (strings[j].Length == 4)
                {
                    Letters[k] = strings[j];
                    k++;

                }

            }

            return Letters;
        }
    }
}
