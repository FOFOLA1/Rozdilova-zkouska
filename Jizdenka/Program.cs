namespace Jizdenka
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rows = 3;
            int cols = 3;
            int holes = 3;

            int[] comb = new int[holes];
            List<int[]> combs = new List<int[]> ();
            //Array<int[]> combs = new int[holes];


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


            for (int i = 0; i < jiz.Length-holes+1; i++)
            {
                comb[0] = i;
                
                for (int j = i+1; j < jiz.Length-holes+2; j++)
                {
                    comb[1] = j;
                    for (int k = j+1; k < jiz.Length-holes+3; k++)
                    {
                        comb[2] = k;
                        combs.Add(comb);
                    }
                }

            }



        }    
    }
}
