using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Mozart
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] menuetts = new int[16, 11]
            {
                { 96, 32, 69, 40, 148, 104, 152, 119, 98, 3, 54 },
                { 22, 6, 95, 17, 74, 157, 60, 84, 142, 87, 130 },
                { 141, 128, 158, 113, 163, 27, 171, 114, 42, 165, 10 },
                { 41, 63, 13, 85, 45, 167, 53, 50, 156, 61, 103 },
                { 105, 146, 153, 161, 80, 154, 99, 140, 75, 135, 28 },
                { 122, 46, 55, 2, 97, 68, 133, 86, 129, 47, 37 },
                { 11, 134, 110, 159, 36, 118, 21, 169, 62, 147, 106 },
                { 30, 81, 24, 100, 107, 91, 127, 94, 123, 33, 5 },
                { 70, 117, 66, 90, 25, 138, 16, 120, 65, 102, 35 },
                { 121, 39, 139, 176, 143, 71, 155, 88, 77, 4, 20 },
                { 26, 126, 15, 7, 64, 150, 57, 48, 19, 31, 108 },
                { 9, 56, 132, 34, 125, 29, 175, 166, 82, 164, 92 },
                { 112, 174, 73, 67, 76, 101, 43, 51, 137, 144, 12 },
                { 49, 18, 58, 160, 136, 162, 168, 115, 38, 59, 124 },
                { 109, 116, 145, 52, 1, 23, 89, 72, 149, 173, 44 },
                { 14, 83, 79, 170, 93, 151, 172, 111, 8, 78, 131 }
            };

            int[,] trios = new int[16, 6]
            {
                { 72, 56, 75, 40, 83, 18 },
                { 6, 82, 39, 73, 3, 45 },
                { 59, 42, 54, 16, 28, 62 },
                { 25, 74, 1, 68, 53, 38 },
                { 81, 14, 65, 29, 37, 4 },
                { 41, 7, 43, 55, 17, 27 },
                { 89, 26, 15, 2, 44, 52 },
                { 13, 71, 80, 61, 70, 94 },
                { 36, 76, 9, 22, 63, 11 },
                { 5, 20, 34, 67, 85, 92 },
                { 46, 64, 93, 49, 32, 24 },
                { 79, 84, 48, 77, 96, 86 },
                { 30, 8, 69, 57, 12, 51 },
                { 95, 35, 58, 87, 23, 60 },
                { 19, 47, 90, 33, 50, 78 },
                { 66, 88, 21, 10, 91, 31 }
            };


            Random rnd = new Random();

            int count = 0;

            List<string> listMenuetts = new List<string>();
            List<string> listTrios = new List<string>();

            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();

            do
            {
                // Using a for loop to loop through the columns and using the random.Next to pick a row number, so i get a random value.
                for (int i = 0; i < menuetts.GetLength(0); i++)
                {

                    int rndmenuetts = rnd.Next(0, 10);

                    int menuettesElement = menuetts[i, rndmenuetts];

                    string locationMenuett = @"Wave\M" + menuettesElement + ".wav"; // getting the file location.

                    listMenuetts.Add(locationMenuett);

                }

                // Using a for loop to loop through the columns and using the random.Next to pick a row number, so i get a random value.
                for (int j = 0; j < trios.GetLength(0); j++)
                {

                    int rndTrios = rnd.Next(0, 5);

                    int triosElement = trios[j, rndTrios];

                    string locationTrios = @"Wave\T" + triosElement + ".wav"; // getting the file location.

                    listTrios.Add(locationTrios);

                    count++;
                }


            }
            while (count != 16);

            String[] menuettArray = listMenuetts.ToArray();
            String[] trioArray = listTrios.ToArray();

            // When I comeback to this code look up how to do this a better way.
            string[] musicArray = { menuettArray[0], trioArray[0], menuettArray[1], trioArray[1], menuettArray[2], trioArray[2], menuettArray[3], trioArray[3], menuettArray[4], trioArray[4], menuettArray[5], trioArray[5], menuettArray[6], trioArray[6], menuettArray[7], trioArray[7], menuettArray[8], trioArray[8], menuettArray[9], trioArray[9], menuettArray[10], trioArray[10], menuettArray[11], trioArray[11], menuettArray[12], trioArray[12], menuettArray[13], trioArray[13], menuettArray[14], trioArray[14], menuettArray[15], trioArray[15] };



            // This foreach loop through the musicArray and plays each song.
            foreach (string musicelement in musicArray)
            {
                Console.WriteLine("Spiller nu: " + musicelement);

                sp.SoundLocation = musicelement;
                sp.Load();
                sp.PlaySync();

            }

            Console.ReadLine();
        }
    }
}
