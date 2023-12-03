using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class MyString
    {

        public string StringCompression(string str)
        {
            string result = string.Empty;
            int i = 0;

            while (i < str.Length)
            {
                char Char = str[i];
                int Count = 0;

                while (i < str.Length && Char == str[i])
                {
                    Count++;
                    i++;
                }

                result += (Count > 1) ?
                    $"{Char}{Count}" :
                    $"{Char}";
            }

            return result;

        }

        public string StringDeCompression( string str)
        {
            int i = 0;
            string result = String.Empty;
            while (i < str.Length)
            {

                string Count = string.Empty;

                if (Char.IsDigit(str[i]))
                {
                    char _Char = str[i - 1];
                    while (i < str.Length && Char.IsDigit(str[i]))
                    {
                        Count += Convert.ToString(str[i]);
                        i++;
                    }

                    result += new string(_Char, Convert.ToInt32(Count) - 1);
                }
                else
                {
                    result += Convert.ToString(str[i]);
                    i++;
                }


            }

            return result;
        }
    }
}
