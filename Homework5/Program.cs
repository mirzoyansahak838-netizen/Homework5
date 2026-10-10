using System.Runtime.InteropServices;

namespace Homework5
{
    class Program
    {
        struct Reading
        {
            public int Temperature;
            public bool Fault;
            public Reading(int i, bool t)
            {
                Temperature = i;
                Fault = t;
            }
        }

        struct Hit
        {
            public int Temperature;
            public int Row;
            public int Col;

            public Hit(int Temperature, int Row, int Col)
            {
                this.Temperature = Temperature;
                this.Row = Row;
                this.Col = Col;
            }


        }

        static void Main()
        {
            Reading[,] r = new Reading[3, 4];

            r[0, 0] = new Reading(5, false);
            r[0, 1] = new Reading(9, true);
            r[0, 2] = new Reading(0, false);
            r[0, 3] = new Reading(1, true);
            r[1, 0] = new Reading(4, false);
            r[1, 1] = new Reading(-6, true);
            r[1, 2] = new Reading(8, false);
            r[1, 3] = new Reading(11, true);
            r[2, 0] = new Reading(3, false);
            r[2, 1] = new Reading(-5, false);
            r[2, 2] = new Reading(2, true);
            r[2, 3] = new Reading(10, true);


            //Hit[] h = new Hit[r.Length];

            ColderThan(5, r);
        }



        static void ColderThan(int limit, Reading[,] array)
        {
            int count0 = 0;
            //stexcum enq loop vory khashvi nor arrayi chapsy, avelrnord tex chzbaxecnelu hamar))
            foreach (Reading n  in array) { if (n.Fault == false&& n.Temperature < limit){ count0++; } }

            int count = 0;
            Hit[] h = new Hit[count0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j].Temperature < limit && array[i, j].Fault == false)
                    {
                        h[count].Temperature = array[i, j].Temperature;
                        h[count].Row = i;
                        h[count].Col = j;
                        count++;

                    }

                }
            }

            for (int i = 0; i < h.Length; i++)
            {
                Console.WriteLine($"Row : {h[i].Row}\n" +
                    $"Col : {h[i].Col}\n" +
                    $"Temperature : {h[i].Temperature}\n");
                Console.WriteLine("**********************************");
            }


        }
    }
}