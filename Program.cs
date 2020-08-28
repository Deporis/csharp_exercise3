using System;

namespace NomCiutats
{
    class Program
    {
        static void Main(string[] args)
        {
            Fase12();
        }
        static void Fase12()
        {
            Console.WriteLine("Type the name of 6 cities:");
            string city1 = Console.ReadLine().ToLower();
            string city2 = Console.ReadLine().ToLower();
            string city3 = Console.ReadLine().ToLower();
            string city4 = Console.ReadLine().ToLower();
            string city5 = Console.ReadLine().ToLower();
            string city6 = Console.ReadLine().ToLower();
            Console.WriteLine($"{city1}, {city2}, {city3}, {city4}, {city5}, {city6}");

            string [] cities = new string[6] {city1, city2, city3, city4, city5, city6};
            string [] sorted = new string[cities.Length];

            int min = cities[0][0];
            string mincity = cities[0];
            int k = 0;
            while(!(k == cities.Length))
            {
                for(int i = 0; i < cities.Length; i++)
                {
                    for(int j = 0; j < mincity.Length; j++)
                    {
                        if(mincity[j] < cities[i][j])
                        {
                            j = mincity.Length;
                        }
                        else if (mincity[j] > cities[i][j])
                        {
                            min = cities[i][j];
                            mincity = cities[i];
                            i = -1;
                            j = mincity.Length;
                        }
                        else
                        {
                            if(mincity == cities[i]) j = mincity.Length;
                        }
                    }
                }
                sorted[k] = mincity;
                k++;
                for(int tilde = 0; tilde < cities.Length;tilde++)
                {
                    if (cities[tilde] == mincity) cities[tilde] = "~";
                }
                mincity = cities[0];
                min = cities[0][0];
            }
            foreach(string city in sorted)
            {
                Console.WriteLine(city);
            }
        }
    }
}
