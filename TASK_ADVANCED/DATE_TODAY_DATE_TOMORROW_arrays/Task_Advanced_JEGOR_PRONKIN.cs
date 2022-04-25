using System;
using System.Text;
using ConsoleInp;
using System.Linq;

namespace SPECIAL_TASK_EXECRISE_NR_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cyrillic
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(1251);
            #endregion





            #region NR1 (using 'for')
            //int startPoint;
            //int finishPoint = 1;
            //int a;
            //int MIN = 0;

            //Console.Write("Вводите целые числа. Кол-во чисел неограничено. ДЛЯ ОСТАНОВКИ ПРОГРАММЫ ВВЕДИТЕ \"0\" \n");
            //Console.WriteLine();

            //for (startPoint = 1; startPoint <= finishPoint++; startPoint++)
            //{
            //    Console.Write("Введите целое число : ");
            //    a = ConsoleInput.ReadInt();

            //    Console.WriteLine("!!!НАПОМИНАНИЕ!!! -> для завершения работы программы введите цифру -> \"0\" \n");

            //    if (a != 0)
            //    {
            //        if (startPoint == 1)
            //        {
            //            MIN = a;
            //        }
            //        if (a < MIN)
            //        {
            //            MIN = a;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Работа программы завершена.");
            //        break;
            //    }
            //}
            //Console.WriteLine("MIN : {0}", MIN);
            //Console.WriteLine();
            #endregion
            #region NR1 (using 'while')
            //int a = 1, ff = 1;
            //int MIN = 0;

            //Console.Write("Вводите целые числа. Кол-во чисел неограничено. ДЛЯ ОСТАНОВКИ ПРОГРАММЫ ВВЕДИТЕ \"0\" \n");
            //Console.WriteLine();

            //while (a != 0)
            //{
            //    Console.Write("Введите целое число : ");
            //    a = ConsoleInput.ReadInt();
            //    Console.WriteLine("!!!НАПОМИНАНИЕ!!! -> для завершения работы программы введите цифру -> \"0\" \n");

            //    if (a != 0)
            //    {
            //        if (ff == 1)
            //        {
            //            MIN = a;
            //        }
            //        if (a < MIN)
            //        {
            //            MIN = a;
            //        }
            //        ff++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Работа программы завершена.");
            //        break;
            //    }
            //}
            //Console.WriteLine("MIN : {0}", MIN);
            //Console.WriteLine();
            #endregion

            #region NR2 (using 'arrays')
            //Console.WriteLine("Укажите три целых числа: YEAR, MONTH и DAY.");
            //try
            //{
            //    Console.Write("YEAR - ");
            //    int y = int.Parse(Console.ReadLine());

            //    Console.Write("MONTH (1-12) - ");
            //    int m = int.Parse(Console.ReadLine());

            //    //Масив количества дней в месяце
            //    int[] mD = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            //    //Уточнение, если год високосный
            //    if (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0))
            //    {
            //        mD[1] = 29;
            //    }
            //    Console.Write("\tDAY (1-{0}) - ", mD[m - 1]);
            //    int d = int.Parse(Console.ReadLine());

            //    if (d >= 1 && d <= 31)
            //    {
            //        if (d != mD[m - 1])
            //            d++;
            //        else if (m != 12)
            //        {
            //            d = 1;
            //            m++;
            //        }
            //        else
            //        {
            //            d = m = 1;
            //            y++;
            //        }

            //        Console.WriteLine("Следующим днем является {0:d2}.{1:d2}.{2}", d, m, y);
            //    } 
            //    else
            //    {
            //        Console.WriteLine("Вы ввели {0}. В месеце до 31 дня, перезапустите программу заново!", d);
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Перезапустите программу заново!");
            //}
            #endregion
            #region NR2 (using 'if')
            //int day, month, year;

            //Console.Write("Введите год : ");
            //year = ConsoleInput.ReadInt();
            //Console.WriteLine();

            //if (year > 0)
            //{
            //    Console.Write("Введите месяц (1-12) : ");
            //    month = ConsoleInput.ReadInt();
            //    Console.WriteLine();
            //    if (month >= 1 && month <= 12)
            //    {
            //        Console.Write("Введите месяц (1-31) : ");
            //        day = ConsoleInput.ReadInt();
            //        Console.WriteLine();
            //        if (day >= 1 && day <= 31)
            //        {
            //            if (day < 30)
            //            {
            //                day++;
            //            }
            //            else
            //            {
            //                if (day == 30)
            //                {
            //                    if (month == 2 || month == 4 || month == 6 || month == 9 || month == 11)
            //                    {
            //                        day = 1;
            //                        month++;
            //                    }
            //                    else
            //                    {
            //                        day++;
            //                    }
            //                }
            //                else
            //                {
            //                    day = 1;
            //                    month++;
            //                }
            //            }

            //            if (month == 13)
            //            {
            //                month = 1;
            //                year++;
            //            }
            //            Console.WriteLine("Tomorrow: {0:d2}.{1:d2}.{2}", day, month, year);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Вы неверно ввели ГОД, МЕСЯЦ или ДЕНЬ, вводите данные корректно, следуя разрешенным промежуткам.\nПерезапустите программу!");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Вы неверно ввели ГОД, МЕСЯЦ или ДЕНЬ, вводите данные корректно, следуя разрешенным промежуткам.\nПерезапустите программу!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Вы неверно ввели ГОД, МЕСЯЦ или ДЕНЬ, вводите данные корректно, следуя разрешенным промежуткам.\nПерезапустите программу!");
            //}
            #endregion
            #region NR2 (using 'while' and 'DateTime' method)
            //bool correct = false;
            //string input;
            //DateTime date = DateTime.Now;
            //while (!correct)
            //{
            //    try
            //    {
            //        Console.Write("Enter your date(Day.Month.Year): ");
            //        input = Console.ReadLine();
            //        date = Convert.ToDateTime(input);
            //        correct = true;
            //    }
            //    catch (Exception)
            //    {
            //        correct = false;
            //    }
            //}
            //input = date.AddDays(1).ToString("dd/MM/yyyy");
            //Console.WriteLine("Tommorow: {0}", input);
            //Console.ReadKey();
            #endregion

            #region NR3
            //double five_hundr_eur, two_hundr_eur, twenty_eur, five_eur, twenty_cent, five_cent;
            //double sum_eur;

            //Console.Write("\tВведите сумму  : ");
            //sum_eur = ConsoleInput.ReadDouble();
            //Console.WriteLine("\tВы ввели сумму : {0:f2}\n", Math.Round(sum_eur,2));

            //five_hundr_eur = sum_eur / 500;
            //sum_eur %= 500;
            //two_hundr_eur = sum_eur / 200;
            //sum_eur %= 200;
            //twenty_eur = sum_eur / 20;
            //sum_eur %= 20;
            //five_eur = sum_eur / 5;
            //sum_eur %= 5;
            //twenty_cent = sum_eur / 0.20;
            //sum_eur %= 0.20;
            //five_cent = sum_eur / 0.05;

            ////При необходимости можно добавить переменные для 100евро, 50евро, 10евро, 2евро, 1евро, 50сентов, 20сентов, 10сентов, 2сента и 1 сент.
            ////И произвести такие же вычесления(как выше), добавив в нужные места подходящее переменные. Сделал, как пример в задании.

            //Console.WriteLine("\t500 euro : {0:f0}", Math.Floor(five_hundr_eur));
            //Console.WriteLine("\t200 euro : {0:f0}", Math.Floor(two_hundr_eur));
            //Console.WriteLine("\t 20 euro : {0:f0}", Math.Floor(twenty_eur));
            //Console.WriteLine("\t  5 euro : {0:f0}", Math.Floor(five_eur));
            //Console.WriteLine("\t 20 cent : {0:f0}", Math.Floor(twenty_cent));
            //Console.WriteLine("\t  5 cent : {0:f0}", five_cent);
            //Console.WriteLine();
            #endregion

            #region NR4
            //int X, n, count = 0;
            //Random obj = new Random();
            //X = obj.Next(0, 1001);
            //Console.WriteLine("******************************************");
            //Console.WriteLine("Загадано число от 0 до 1000. Угадайте его!");
            //Console.WriteLine("__________________________________________\n");

            //do
            //{
            //    Console.Write("Введите число : ");
            //    n = ConsoleInput.ReadInt();
            //    if (n == X)
            //    {
            //        count++;
            //        Console.WriteLine("Поздравляю Вы угадали число с {0} попытки", count);
            //        break;
            //    }
            //    else
            //    {
            //        count++;
            //        if (n > X && n >= 0 && n <= 1000)
            //        {
            //            Console.WriteLine("Вы не угадали! Подсказка: много!\n");
            //        }
            //        else if (n < X && n >= 0 && n <= 1000)
            //        {
            //            Console.WriteLine("Вы не угадали! Подсказка: мало!\n");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Не вводите числа вне диапазона загаданного числа.");
            //        }
            //    }
            //} while (n != X);
            #endregion

            #region NR5
            //    string psw;

            //    Console.Write("Введите придуманный пароль : ");
            //repeat1:
            //    psw = Console.ReadLine();
            //    Console.WriteLine();

            //    if (psw.Any(char.IsUpper) && psw.Any(char.IsLower) && psw.Any(char.IsDigit))
            //    {
            //        Console.Write("Пароль придуман верно!\nВведите его второй раз: ");
            //    repeat2:
            //        string psw2 = Console.ReadLine();
            //        Console.WriteLine();
            //        if (psw2 == psw)
            //        {
            //            Console.WriteLine("Пароль создан УСПЕШНО!");
            //        }
            //        else
            //        {
            //            Console.Write("Пароль не совпадает.Повторите ещё раз!\nВведите пароль : ");
            //            goto repeat2;
            //        }
            //    }
            //    else
            //    {
            //        Console.Write("ERROR! Пароль дожен содержать: одну большу букву, одну маленькую букву и цифру! Попробуйте ещё раз!\nВведите пароль : ");
            //        goto repeat1;
            //    }
            //    Console.WriteLine();
            #endregion





            #region Pause
            Console.WriteLine("Press any button to continue...");
            Console.ReadKey();
            #endregion
        }
    }
}




