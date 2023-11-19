using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public class Generator
    {
        private int length;
        public bool[] Options { get; private set; }
        public string TextBoxSymbols { get; private set; }

        public Generator(int length, bool[] options, string str)
        {
            Length = length;
            Options = options;
            TextBoxSymbols = str;
        }

        public int Length
        {
            get { return length; }
            set
            {
                length = value > 0 ? value : 1;
            }
        }


        public string Generate()
        {
            string password = Options[4] ? GeneratorWithNoRepetitions() : GeneratorWithRepetitions();
            return password;
        }

        private string GeneratorWithRepetitions()
        {
            var st = new StringBuilder(length);
            Random r = new();

            for (int i = 0; i < length; i++)
            {
                if (Options[5]) { st.Append(GetRequestedSymbol(r)); }
                else
                {
                    switch (r.Next(1, 5))
                    {
                        case 1:
                            {
                                if (Options[0]) { st.Append(GetNumber(r)); }
                                else { i--; }
                                break;
                            }
                        case 2:
                            {
                                if (Options[1]) { st.Append(GetLowerLetter(r)); }
                                else { i--; }
                                break;
                            }
                        case 3:
                            {
                                if (Options[2]) { st.Append(GetUpperLetter(r)); }
                                else { i--; }
                                break;
                            }
                        case 4:
                            {
                                if (Options[3]) { st.Append(GetSpecialSymbol(r)); }
                                else { i--; }
                                break;
                            }
                    }
                }
            }
            return st.ToString();
        }

        private string GeneratorWithNoRepetitions()
        {
            var st = new StringBuilder(length);
            Random r = new();

            for (int i = 0; i < length; i++)
            {
                if (Options[5]) { st.Append(GetRequestedSymbol(r));}
                else
                {
                    switch (r.Next(1, 5))
                    {
                        case 1:
                            {
                                if (Options[0]) { st.Append(GetNumber(r)); }
                                else { i--; }
                                break;
                            }
                        case 2:
                            {
                                if (Options[1]) { st.Append(GetLowerLetter(r));}
                                else { i--; }
                                break;
                            }
                        case 3:
                            {
                                if (Options[2]) { st.Append(GetUpperLetter(r)); }
                                else { i--; }
                                break;
                            }
                        case 4:
                            {
                                if (Options[3]) { st.Append(GetSpecialSymbol(r)); }
                                else { i--; }
                                break;
                            }
                    }
                }
                if (st.Length > 1)
                {
                    char c = st[st.Length - 1];
                    for (int j = 0; j < st.Length-1; j++)
                    {
                        if (st[j].Equals(c))
                        {
                            i--;
                            st.Remove(st.Length - 1, 1);
                            break;
                        }
                    }
                }
            }
            return st.ToString();
        }
        string GetNumber(Random r) => char.ConvertFromUtf32(r.Next(48, 58));
        string GetUpperLetter(Random r) => char.ConvertFromUtf32(r.Next(65, 91));
        string GetLowerLetter(Random r) => char.ConvertFromUtf32(r.Next(97, 123));
        string GetSpecialSymbol(Random r) => char.ConvertFromUtf32(r.Next(33, 48));
        string GetRequestedSymbol(Random r) => TextBoxSymbols[r.Next(0, TextBoxSymbols.Length)].ToString();
    }
}
