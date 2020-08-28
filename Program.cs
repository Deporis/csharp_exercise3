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
            string city1 = Console.ReadLine();
            string city2 = Console.ReadLine();
            string city3 = Console.ReadLine();
            string city4 = Console.ReadLine();
            string city5 = Console.ReadLine();
            string city6 = Console.ReadLine();
            Console.WriteLine($"{city1}, {city2}, {city3}, {city4}, {city5}, {city6}");

            string [] cities = new string[6] {city1, city2, city3, city4, city5, city6};
            string [] sorted = new string[cities.Length];

            int min = cities[0][0];
            string mincity = cities[0];
            int k = 0;

            // Comparamos todas las posibilidades de nuestra array cities, calculando qué char
            // es el más pequeño según el código ASCII. En el caso que la primera letra sean iguales
            // comparamos la segunda letra, para poder editar el array cities y no repetir valores
            // el último añadido se convierte en tilde, qué es el char más grande de ASCII imprimibles

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
            // Checking if it is the correct order
            foreach(string city in sorted)
            {
                Console.WriteLine(city);
            }
            
            Fase3(sorted);
        }
        static void Fase3(string [] sortedArray)
        {
            string [] arrayCiutatsModificades = new string[sortedArray.Length];

            for(int city = 0; city < sortedArray.Length; city++)
            {
                for(int letter = 0; letter < sortedArray[city].Length; letter++)
                {
                    string strLetter = sortedArray[city][letter].ToString();
                    if(strLetter == "a")
                    {
                        strLetter = "4";
                        arrayCiutatsModificades[city] += strLetter;
                    }
                    else
                    {
                        arrayCiutatsModificades[city] += strLetter;
                    }
                }
            }
            foreach(string i in arrayCiutatsModificades)
            {
                Console.WriteLine(i);
            }
        }
    }
}
