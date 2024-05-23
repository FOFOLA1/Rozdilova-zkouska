using System;
using static System.Net.Mime.MediaTypeNames;

namespace Jizdenka
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rows = 2;
            int cols = 2;
            int holes = 2;

            List<int[]> combs = new List<int[]> ();


            //do
            //{
            //    Console.Write("Počet řádků: ");
            //} while (!Int32.TryParse(Console.ReadLine(), out rows));

            //do
            //{
            //    Console.Write("Počet sloupců: ");
            //} while (!Int32.TryParse(Console.ReadLine(), out cols));

            //do
            //{
            //    Console.Write("Počet děr: ");
            //} while (!Int32.TryParse(Console.ReadLine(), out holes));

            int[] jiz = new int[rows * cols];

            for (int i = 0; i < jiz.Length; i++)
            {
                jiz[i] = i + 1;
            }

            combinations(jiz, new int[holes], 0, jiz.Length - 1, 0, holes, combs);
            string txt = formatJiz(combs, rows, cols);
            Console.WriteLine(txt);

        }

        static void combinations(int[] jiz, int[] comb, int start, int len, int index, int holes, List<int[]> combs)
        {

            if (index == holes)
            {
                int[] temp = new int[holes];
                for (int j = 0; j < holes; j++)
                {
                    temp[j] = comb[j];
                }
                combs.Add(temp);
                return;
            }

            for (int i = start; i <= len && len - i + 1 >= holes - index; i++)
            {
                comb[index] = jiz[i];
                combinations(jiz, comb, i + 1, len, index + 1, holes, combs);
            }
        }

        static string formatJiz(List<int[]> combs, int rows, int cols)
        {
            int maxlen = (rows * cols).ToString().Length;
            int count = 0;
            int temp;

            string betwline = "";
            for (int i = 0; i < cols; i++)
            {
                betwline += " " + new string('-', maxlen);
            }

            string numline = "";
            string num;
            string str = "";
            string strOut = "";

            foreach (int[] item in combs)
            {
                count++;
                str = count + "\n";

                str += betwline + "\n";

                for (int i = 1; i <= (cols * rows); i++)
                {
                    if (i != cols) temp = i;
                    else temp = i%cols;

                    if (item.Any(cislo => cislo == temp))
                    {
                        numline += "|" + new string('\u2588', maxlen);
                    }
                    else
                    {
                        num = String.Format("{0," + maxlen + "}", i);
                        numline += "|" + num;
                    }
                    

                    if (i%cols == 0)
                    {
                        numline += "|\n" + betwline + "\n";
                    }
                }
                str += numline + "\n";
                strOut += str;
            }
            return strOut;
        }

    }

    // Program najde všechny možnosti správně, ale výpis nefunguje
}
