using System;

namespace TrainConsole22
{
    internal class Program
    {
        public static void Main()
        {

            {

            }

            while (true)
            {
                Console.WriteLine("Нажмите Enter, для начала обслуживания нового клиента");
                Console.ReadKey();

                string countryCode;
                decimal tileQuentity, tilePrice;
                // countryCode, tileQuntity, tilePrice = RunInputUserInterface()
                {
                    const string COUNTRY_CODES =
                        "=============================================================\n" +
                        "Азербайджан  (994)   | Киргизия   (996)   | Таджикистан (992)\n" +
                        "Армения      (374)   | Латвия     (371)   | Туркмения   (993)\n" +
                        "Беларусь     (375)   | Литва      (470)   | Узбекистан  (998)\n" +
                        "Грузия       (995)   | Молдова    (373)   | Украина     (380)\n" +
                        "Казахстан    (007K)  | Россия     (007)   | Эстония     (372)\n" +
                        "----------------------------------------------------------";

                    Console.WriteLine(COUNTRY_CODES);

                    // countryCode = ProcessCountryCode (countryCode)
                    {
                        bool countryCodeIsCorrect;
                        do
                        {
                            Console.Write("Телефонный код страны: ");
                            countryCode = Console.ReadLine();

                            // countryCode = DetectKazakhstanCode (countryCode)
                            {
                                const string KAZAKHSTAN_CODE = "007";
                                const string /*UPPERCASE_ENGLISH_LETTER_K = "K",*/ LOWERCASE_ENGLISH_LETTER_K = "k",
                                             UPPERCASE_RUSSIAN_LETTER_K = "К", LOWERCASE_RUSSIAN_LETTER_K = "к";

                                bool countryCodeIsKazakhstanCodeAndAnyLetterK =
                                             //countryCode == (KAZAKHSTAN_CODE + UPPERCASE_ENGLISH_LETTER_K) ||
                                             countryCode == (KAZAKHSTAN_CODE + LOWERCASE_ENGLISH_LETTER_K) ||
                                             countryCode == (KAZAKHSTAN_CODE + UPPERCASE_RUSSIAN_LETTER_K) ||
                                             countryCode == (KAZAKHSTAN_CODE + LOWERCASE_RUSSIAN_LETTER_K);

                                if (countryCodeIsKazakhstanCodeAndAnyLetterK)
                                {
                                    const string UPPERCASE_ENGLISH_LETTER_K = "K";
                                    countryCode = KAZAKHSTAN_CODE + UPPERCASE_ENGLISH_LETTER_K;
                                }
                            }

                            // countryCodeIsCorrect = CheckCountryCode (countryCode)
                            {
                                const string UPPERCASE_ENGLISH_LETTER_K = "K";
                                const string AZERBAJAN_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375",
                                             GEORGIA_CODE = "995", KAZAKHSTAN_CODE = "007" + UPPERCASE_ENGLISH_LETTER_K,
                                             KYRGYSTAN_CODE = "996", LATVIA_CODE = "371", LITHUANIA_CODE = "370",
                                             MOLDOVA_CODE = "373", RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992", TURMENISTAN_CODE = "993",
                                             UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";

                                switch (countryCode)
                                {
                                    case AZERBAJAN_CODE:
                                    case ARMENIA_CODE:
                                    case BELARUS_CODE:
                                    case UKRAINE_CODE:
                                    case RUSSIA_CODE:
                                    case GEORGIA_CODE:
                                    case KAZAKHSTAN_CODE:
                                    case KYRGYSTAN_CODE:
                                    case LATVIA_CODE:
                                    case LITHUANIA_CODE:
                                    case ESTONIA_CODE:
                                    case MOLDOVA_CODE:
                                    case TAJIKISTAN_CODE:
                                    case TURMENISTAN_CODE:
                                    case UZBEKISTAN_CODE:
                                        {
                                            countryCodeIsCorrect = true;
                                            break;
                                        }
                                    default:
                                        {
                                            countryCodeIsCorrect = false;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine($"Вы ввели несуществующий код: {countryCode}");
                                            Console.ResetColor();
                                            break;
                                        }
                                }

                            }

                        }
                        while (!countryCodeIsCorrect);
                    }
                        Console.Write("Прошу ввести количество плитки в кв метрах: ");
                        string stringQuentity = Console.ReadLine();
                        tileQuentity = decimal.Parse(stringQuentity);

                        Console.Write("Прошу ввести цену одной плитки за 1 кв. метр: ");
                        string stringPrice = Console.ReadLine();
                        tilePrice = decimal.Parse(stringPrice);
                    }

                    // rate = CalculatePriceRate (countryCode)
                    decimal rate;
                    {
                        const string UPPERCASE_ENGLISH_LETTER_K = "K";
                        const string AZERBAJAN_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375",
                                     GEORGIA_CODE = "995", KAZAKHSTAN_CODE = "007" + UPPERCASE_ENGLISH_LETTER_K,
                                     KYRGYSTAN_CODE = "996", LATVIA_CODE = "371", LITHUANIA_CODE = "370",
                                     MOLDOVA_CODE = "373", RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992", TURMENISTAN_CODE = "993",
                                     UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";

                        switch (countryCode)
                        {
                            case AZERBAJAN_CODE:
                                {
                                    const decimal AZERBAJAN_RATE = 1.07m;
                                    rate = AZERBAJAN_RATE;
                                    break;
                                }
                            case ARMENIA_CODE:
                                {
                                    const decimal ARMENIA_RATE = 0.95m;
                                    rate = ARMENIA_RATE;
                                    break;
                                }
                            case BELARUS_CODE:
                            case UKRAINE_CODE:
                            case RUSSIA_CODE:
                                {
                                    const decimal RUSSIA_RATE = 1.00m;
                                    rate = RUSSIA_RATE;
                                    break;
                                }
                            case GEORGIA_CODE:
                                {
                                    const decimal GEORGIA_RATE = 0.94m;
                                    rate = GEORGIA_RATE;
                                    break;
                                }
                            case KAZAKHSTAN_CODE:
                                {
                                    const decimal KAZAKHSTAN_RATE = 0.79m;
                                    rate = KAZAKHSTAN_RATE;
                                    break;
                                }
                            case KYRGYSTAN_CODE:
                                {
                                    const decimal KYRGYSTAN_RATE = 0.83m;
                                    rate = KYRGYSTAN_RATE;
                                    break;
                                }
                            case LATVIA_CODE:
                            case LITHUANIA_CODE:
                            case ESTONIA_CODE:
                                {
                                    const decimal ESTONIA_RATE = 1.12m;
                                    rate = ESTONIA_RATE;
                                    break;
                                }
                            case MOLDOVA_CODE:
                                {
                                    const decimal MOLDOVA_RATE = 0.97m;
                                    rate = MOLDOVA_RATE;
                                    break;
                                }
                            case TAJIKISTAN_CODE:
                                {
                                    const decimal TAJIKISTAN_RATE = 0.76m;
                                    rate = TAJIKISTAN_RATE;
                                    break;
                                }
                            case TURMENISTAN_CODE:
                                {
                                    const decimal TURMENISTAN_RATE = 0.81m;
                                    rate = TURMENISTAN_RATE;
                                    break;
                                }
                            case UZBEKISTAN_CODE:
                                {
                                    const decimal UZBEKISTAN_RATE = 0.98m;
                                    rate = UZBEKISTAN_RATE;
                                    break;
                                }
                            default:
                                {
                                    rate = 0;
                                    break;
                                }
                        }
                    }

                    decimal tilePriceWithRate = tilePrice * rate;
                    decimal tileCost = tileQuentity * tilePriceWithRate; //руб


                    decimal discount; // руб
                    {
                        decimal discountPersentage;
                        {
                            bool discount20PctAvailable, discount50PctAvailable;
                            {
                                const decimal MIN_TILE_QTY_FOR_DISCOUNT_20_PCT = 500,
                                              MIN_TILE_QTY_FOR_DISCOUNT_50_PCT = 1000; // м.кв

                                discount20PctAvailable = tileQuentity >= MIN_TILE_QTY_FOR_DISCOUNT_20_PCT &&
                                                     tileQuentity < MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;

                                discount50PctAvailable = tileQuentity >= MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;
                            }

                            if (discount20PctAvailable)
                            {
                                discountPersentage = 20; // %
                            }
                            else if (discount50PctAvailable)
                            {
                                discountPersentage = 50;
                            }
                            else
                            {
                                discountPersentage = 0;
                            }
                        }

                        discount = tileCost / 100 * discountPersentage;
                    }

                    decimal paymentAmount;
                    {
                        paymentAmount = tileCost - discount;
                    }

                    // RunOutputUserInterface (tilePriceWithRate, tileCost, discount, paymentAmount)
                    {
                        Console.WriteLine($"цена с коэфициентом     = {tilePriceWithRate}");
                        Console.WriteLine($"Общая стоимость плитки  = {tileCost}");
                        Console.WriteLine($"Cумма скидки            = {discount}");
                        Console.WriteLine($"Cумма к оплате          = {paymentAmount}");
                    }


                

            }

        }
    }
}



