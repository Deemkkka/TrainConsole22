using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberOfTypesOfTiles, numberOfTypesOfMaterials;
            {
                Console.Write("Введите количество разновидностей плитки: ");
                numberOfTypesOfTiles = int.Parse(Console.ReadLine());
                Console.Write("Введите количество видов сырья для изготовления плитки: ");
                numberOfTypesOfMaterials = int.Parse(Console.ReadLine());
            }

            decimal[,] listValueMaterials = new decimal[numberOfTypesOfTiles, numberOfTypesOfMaterials],
                       listPriceMaterials = new decimal[numberOfTypesOfMaterials, 1],
                       listPlannedValueTiles = new decimal[numberOfTypesOfTiles, 1],
                       listCostTiles = new decimal[numberOfTypesOfTiles, 1];

            for (int i = 0; i < listValueMaterials.GetLength(0); i++)
            {
                for (int j = 0; j < listValueMaterials.GetLength(1); j++)
                {
                    Console.Write($"Введите объем сырья № {j + 1} для плитки № {i + 1} (кг): ");
                    listValueMaterials[i, j] = decimal.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < listPriceMaterials.Length; i++)
            {
                Console.Write($"Введите цену сырья N {i + 1} (руб): ");
                listPriceMaterials[i, 0] = decimal.Parse(Console.ReadLine());
            }

            for (int i = 0; i < listPlannedValueTiles.Length; i++)
            {
                Console.Write($"Введите планируемый объем выпуска N {i + 1} (в штуках): ");
                listPlannedValueTiles[i, 0] = decimal.Parse(Console.ReadLine());
            }

            //CalculateTotalCostOfMaterials (sandAndClayList, listSandAndClayPrice, listPlannedVolumeOfTiles, plannedCostOfTiles)
            {
                for (int i = 0; i < listValueMaterials.GetLength(0); i++)
                {
                    for (int j = 0; j < listValueMaterials.GetLength(1); j++)
                    {
                        listCostTiles[i, 0] += listValueMaterials[i, j] * listPriceMaterials[j, 0];
                    }
                }

                //ОбщаяСтоимость = планируемыеЗатратыНаПлитку1 + планируемыеЗатратыНаПлитку1 + планируемыеЗатратыНаПлитку3
                decimal totalCost = 0;

                for (int i = 0; i < listCostTiles.Length; i++)
                {
                    totalCost += listPlannedValueTiles[i, 0] * listCostTiles[i, 0];
                }

                Console.WriteLine($"Общая сумма = {totalCost}");
            }
            Console.ReadKey();

        }
    }
}
