using System;
using static System.Net.Mime.MediaTypeNames;

namespace Jizdenka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int rows = 1;
            int cols = 1;
            int holes = 1;

            List<int[]> combs = new List<int[]> ();


            do
            {
                Console.Write("Počet řádků: ");
            } while (!(Int32.TryParse(Console.ReadLine(), out rows) && rows > 0));

            do
            {
                Console.Write("Počet sloupců: ");
            } while (!(Int32.TryParse(Console.ReadLine(), out cols) && cols > 0));

            do
            {
                Console.Write("Počet děr: ");
            } while (!(Int32.TryParse(Console.ReadLine(), out holes) && holes > 0 && rows*cols >= holes));

            int[] jiz = new int[rows * cols];

            for (int i = 0; i < jiz.Length; i++)
            {
                jiz[i] = i + 1;
            }

            combinations(jiz, new int[holes], 0, jiz.Length - 1, 0, holes, combs);
            string txt = formatJiz(combs, rows, cols);
            Console.WriteLine(txt);
            string path = printToFile(txt);

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

            string betwline = "";
            for (int i = 0; i < cols; i++)
            {
                betwline += " " + new string('-', maxlen);
            }

            string numline = "";
            string str = "";
            string strOut = "";
            int numControl;

            foreach (int[] item in combs)
            {
                count++;
                str = count + "\n";
                str += betwline + "\n";

                numControl = 0;
                for (int col = 1; col <= cols; col++)
                {
                    for (int row = 1; row <= rows; row++)
                    {
                        numControl++;

                        if (item.Any(cislo => cislo == numControl))
                        {
                            numline += "|" + new string('\u2588', maxlen);
                        }
                        else
                        {
                            numline += "|" + String.Format("{0," + maxlen + "}", numControl);
                        }

                        if (numControl % cols == 0)
                        {
                            numline += "|\n" + betwline + "\n";
                        }
                    }
                }

                str += numline + "\n";
                numline = "";
                strOut += str;
            }
            return strOut;
        }

        static string printToFile(string txt)
        {
            string path = "";



            return path;
        }
    }
}
