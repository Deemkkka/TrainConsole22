using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "январь", "февраль", "март" };
            string[] tiles = { "Агат", "Оникс", "Малахит" };
            string[] distributors = { "Мир керамики", "Дом плитки" };
            string[] countries = { "Италия", "Испания" };
            decimal[,,,] array = new decimal[countries.Length, distributors.Length, tiles.Length, months.Length];

            for (int w = 0; w < array.GetLength(0); w++)
                for (int z = 0; z < array.GetLength(1); z++)
                    for (int y = 0; y < array.GetLength(2); y++)
                        for (int x = 0; x < array.GetLength(3); x++)
                        {
                            Console.WriteLine($"{distributors[z]} продал плитки {tiles[y]} за {months[x]} в {countries[w]}: ");
                            array[w, z, y, x] = decimal.Parse(Console.ReadLine());
                        }

            while (true)
            {
                Console.Write("Введите имя дистрибьютера: ");
                string distributorName = Console.ReadLine();
                Console.Write("Введите название вида плитки ");
                string tileName = Console.ReadLine();

                int distributorIndex = Array.IndexOf(distributors, distributorName);
                int tileIndex = Array.IndexOf(tiles, tileName);

                decimal numberOfTiles = 0;

                for (int w = 0; w < array.GetLength(0); w++)
                    for (int x = 0; x < array.GetLength(3); x++)
                    {
                        numberOfTiles += array[w, distributorIndex, tileIndex, x];
                    }

                Console.WriteLine($"{distributorName} продал {numberOfTiles} шт. плитки за квартал");

            }

            Console.ReadKey();

        }
    }
}
