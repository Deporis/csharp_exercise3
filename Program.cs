using System;

namespace NomCiutats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the name of 6 cities:");
            string city1 = Console.ReadLine();
            string city2 = Console.ReadLine();
            string city3 = Console.ReadLine();
            string city4 = Console.ReadLine();
            string city5 = Console.ReadLine();
            string city6 = Console.ReadLine();
            Console.WriteLine($"{city1}, {city2}, {city3}, {city4}, {city5}, {city6}");
            
            Fase12(city1, city2, city3, city4, city5, city6);
            Console.WriteLine("\n");
            Fase4(city1, city2, city3, city4, city5, city6);
            Console.WriteLine("\n");
            Fase4M(city1, city2, city3, city4, city5, city6);
        }
        static void Fase12(string city1, string city2, string city3, string city4, string city5, string city6)
        {
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
            Console.WriteLine("\n");
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
            foreach(string ciutat in arrayCiutatsModificades)
            {
                Console.WriteLine(ciutat);
            }
        }
        static void Fase4(string city1, string city2, string city3, string city4, string city5, string city6)
        {
            string [] revcity1 = new string[city1.Length];
            string [] revcity2 = new string[city2.Length];
            string [] revcity3 = new string[city3.Length];
            string [] revcity4 = new string[city4.Length];
            string [] revcity5 = new string[city5.Length];
            string [] revcity6 = new string[city6.Length];

            int k = 0;
            string cityrev1 = "";
            for(int i = city1.Length - 1; i >= 0; i--)
            {
                string chars1 = city1[i].ToString();
                revcity1[k] = chars1;
                k++;
            }
            for(int j = 0; j < revcity1.Length; j++)
            {
                cityrev1 += revcity1[j];
            }
            Console.WriteLine(cityrev1);
            
            k = 0;
            string cityrev2 = "";

            for(int i = city2.Length - 1; i >= 0; i--)
            {
                string chars2 = city2[i].ToString();
                revcity2[k] = chars2;
                k++;
            }
            for(int j = 0; j < revcity2.Length; j++)
            {
                cityrev2 += revcity2[j];
            }
            Console.WriteLine(cityrev2);

            k = 0;
            string cityrev3 = "";

            for(int i = city3.Length - 1; i >= 0; i--)
            {
                string chars3 = city3[i].ToString();
                revcity3[k] = chars3;
                k++;
            }
            for(int j = 0; j < revcity3.Length; j++)
            {
                cityrev3 += revcity3[j];
            }
            Console.WriteLine(cityrev3);

            k = 0;
            string cityrev4 = "";

            for(int i = city4.Length - 1; i >= 0; i--)
            {
                string chars4 = city4[i].ToString();
                revcity4[k] = chars4;
                k++;
            }
            for(int j = 0; j < revcity4.Length; j++)
            {
                cityrev4 += revcity4[j];
            }
            Console.WriteLine(cityrev4);
            
            k = 0;
            string cityrev5 = "";

            for(int i = city5.Length - 1; i >= 0; i--)
            {
                string chars5 = city5[i].ToString();
                revcity5[k] = chars5;
                k++;
            }
            for(int j = 0; j < revcity5.Length; j++)
            {
                cityrev5 += revcity5[j];
            }
            Console.WriteLine(cityrev5);
            
            k = 0;
            string cityrev6 = "";

            for(int i = city6.Length - 1; i >= 0; i--)
            {
                string chars6 = city6[i].ToString();
                revcity6[k] = chars6;
                k++;
            }
            for(int j = 0; j < revcity6.Length; j++)
            {
                cityrev6 += revcity6[j];
            }
            Console.WriteLine(cityrev6);
        }
        static void Fase4M(string city1, string city2, string city3, string city4, string city5, string city6)
        {
            // Para poder recorrer todos los strings y no ir uno por uno
            string [] cities = {city1, city2, city3, city4, city5, city6};
            // Cada string esta en una nueva array
            string [] revcity1 = new string[city1.Length];
            string [] revcity2 = new string[city2.Length];
            string [] revcity3 = new string[city3.Length];
            string [] revcity4 = new string[city4.Length];
            string [] revcity5 = new string[city5.Length];
            string [] revcity6 = new string[city6.Length];
            // array de array para poder movernos por dentro y añadir los valores iterando 
            string [][] revcities = {revcity1, revcity2, revcity3, revcity4, revcity5, revcity6};
            
            for(int revcity = 0; revcity < revcities.Length; revcity++)
            {
                int newPosition = 0;
                string cityrev0 = "";
                string chars = "";
                for(int i = revcities[revcity].Length - 1; i >= 0; i--)
                {
                    chars = cities[revcity][i].ToString();
                    revcities[revcity][newPosition] = chars;
                    newPosition++;
                }
                for(int m = 0; m < revcities[revcity].Length; m++)
                {
                    cityrev0 += revcities[revcity][m];
                }
                Console.WriteLine(cityrev0);
            }
        }
    }
}
