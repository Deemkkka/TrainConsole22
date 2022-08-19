using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTrain
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Запросить и принять план продаж
            decimal plan;
            {
                Console.Write("Введите план продаж (в руб): ");
                plan = decimal.Parse(Console.ReadLine());
            }

            // 2. Запросить и принять список фамилий продажников
            string[] surnamesArray;
            {
                Console.WriteLine("Введите фамилии сотрудников через запятую: ");
                string surnames = Console.ReadLine();
                surnamesArray = surnames.Split(',');

                for (int i = 0; i < surnamesArray.Length; i++)
                {
                    surnamesArray[i] = surnamesArray[i].Trim();
                }
            }

            // 3. Запросить и принять список сумм продаж каждого продажника

            decimal[][] totalSalesOfEachSeller;
            {
                totalSalesOfEachSeller = new decimal[surnamesArray.Length][];

                for (int i = 0; i < surnamesArray.Length; i++)
                {
                    Console.WriteLine($"Введите через запятую суммы продаж которые совершил {surnamesArray[i]}: ");
                    string sums = Console.ReadLine();
                    string[] sumsArray = sums.Split(',');
                    totalSalesOfEachSeller[i] = new decimal[sumsArray.Length];

                    for (int j = 0; j < sumsArray.Length; j++)
                    {
                        string sum = sumsArray[j].Trim();
                        totalSalesOfEachSeller[i][j] = decimal.Parse(sum);
                    }
                }
            }

            // 4. Формирование массива общих сумм продаж по каждому продажнку
            decimal[] totalSumsArray;
            {
                totalSumsArray = new decimal[totalSalesOfEachSeller.Length];

                for (int i = 0; i < totalSumsArray.Length; i++)
                {
                    decimal totalSum = 0;

                    for (int j = 0; j < totalSalesOfEachSeller[i].Length; j++)
                    {
                        totalSum += totalSalesOfEachSeller[i][j];
                    }
                    totalSumsArray[i] = totalSum;
                }
            }

            // 5. Формирование отчета кто и насколько процентов недовыполнил или перевыполнил план
            for (int i = 0; i < totalSumsArray.Length; i++)
            {
                Console.Write($"{surnamesArray[i]} продал товара на сумму {totalSumsArray[i]} руб. ");
                decimal persent;

                if (totalSumsArray[i] < plan)
                {
                    persent = (plan - totalSumsArray[i]) / (plan / 100);
                    Console.WriteLine($"План недовыполнен на {persent} %");
                }
                else if (totalSumsArray[i] == 0)
                {
                    Console.WriteLine("План выполнен на 100 %");
                }
                else if(totalSumsArray[i] > plan)
                {
                    persent = (totalSumsArray[i] - plan) / (plan / 100);
                    Console.WriteLine($"План перевыполнен на {persent} %");
                }
            }


            // 6. Формирование отчета о минимальной и максимальной продаже для каждого сейла
            for (int i = 0; i < totalSalesOfEachSeller.Length; i++)
            {
                Array.Sort(totalSalesOfEachSeller[i]);
                int lastIndex = totalSalesOfEachSeller[i].Length - 1;
                Console.WriteLine($"{surnamesArray[i]}: Мин. продажа = {totalSalesOfEachSeller[i][0]}, Макс. продажа {totalSalesOfEachSeller[i][lastIndex]}");
            }

            //
            Console.ReadKey();
        }
    }
}
