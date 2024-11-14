using System;
namespace Homework
{



    class Program
    {

        

        static void Main ()
        {

            //1 
            
            Console.WriteLine("1)");
            Console.WriteLine("Информация о каждом типе данных");

            Console.WriteLine("Тип данных – максимальное значение – минимальное значение");
            Console.WriteLine($"sbyte – '{sbyte.MaxValue}' – '{sbyte.MinValue}'");
            Console.WriteLine($"byte – '{byte.MaxValue}' – '{byte.MinValue}'");
            Console.WriteLine($"short – '{short.MaxValue}' – '{short.MinValue}'");
            Console.WriteLine($"ushort – '{ushort.MaxValue}' – '{ushort.MinValue}'");
            Console.WriteLine($"int – '{int.MaxValue}' – '{int.MinValue}'");
            Console.WriteLine($"uint – '{uint.MaxValue}' – '{uint.MinValue}'");
            Console.WriteLine($"long – '{long.MaxValue}' – '{long.MinValue}'");
            Console.WriteLine($"long – '{ulong.MaxValue}' – '{ulong.MinValue}'");
            Console.WriteLine($"char – '{char.MaxValue}' – '{char.MinValue}'");
            Console.WriteLine($"float – '{float.MaxValue}' – '{float.MinValue}'");
            Console.WriteLine($"double – '{double.MaxValue}' – '{double.MinValue}'");
            Console.WriteLine($"sbyte – '{sbyte.MaxValue}' – '{sbyte.MinValue}'");
            Console.WriteLine($"decimal – '{decimal.MaxValue}' – '{decimal.MinValue}'");


            //2
            
            Console.WriteLine("2)");
            Console.WriteLine("Программа, в которой принимаются данные пользователя в виде имени,города, возраста и PIN-кода.");


            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите город, в котором вы живете:");
            string city = Console.ReadLine();

            int age;
            while (true)
            {
                Console.WriteLine("Введите ваш возраст:");
              
                string age1 = Console.ReadLine();
                if (age1.Length < 3 & age1 != "0" & age1 != null & int.TryParse(age1, out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите ваш настоящий возраст!");
                }
            }
            

            int pin_code;
            while (true)
            {
                Console.WriteLine("Введите Pin Code:");

                string pin_code1 = Console.ReadLine();
                if (pin_code1.Length >= 4 & pin_code1 != null & int.TryParse(pin_code1, out pin_code))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Пинкод должен состоять из цифр и их должно быть не менее 4х");
                }
            }

            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Город: {city}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Пин-код: {pin_code}");



            //3

            Console.WriteLine("3)");
            Console.WriteLine("Заменить на строчные буквы на заглавные, заглавные – на настрочные.");

            string allstring = Console.ReadLine();
            for (int i = 0; i < allstring.Length; i++)
            {
                if (char.IsLower(allstring[i]))
                    Console.Write(char.ToUpper(allstring[i]));
                else if (char.IsUpper(allstring[i]))
                    Console.Write(char.ToLower(allstring[i]));
                else
                    Console.Write(allstring[i]);
            }
           





            //4

            Console.WriteLine("4)");
            Console.WriteLine("Найти количество вхождений и вывести на экран.");

            Console.WriteLine("Введите строку:");
            string stroka = Console.ReadLine();
            Console.WriteLine("Введите подстроку:");
            string podstroka = Console.ReadLine();

            int count = 0;
            int index = 0;

            if (stroka != null & stroka.Length >= podstroka.Length)
            {

                while ((index = stroka.IndexOf(podstroka, index)) != -1)
                {

                    count += 1;
                    index = index + podstroka.Length;

                }

            }

            else
            {
                Console.WriteLine("Некорректные значения");
            }

            if (count!=0) 
            {

                Console.WriteLine($"Количество вхождений: {count}");

            }
            else
            {
                Console.WriteLine("Вхождений нет");
            }



            //5

            Console.WriteLine("5)");
            Console.WriteLine("Определить, сколько бутылок виски беспошлинной торговли вам нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически покрыла расходы на ваш отпуск.");

            Console.WriteLine("Обычная цена:");
            string normPriceStr=Console.ReadLine();
            int normPrice=int.Parse(normPriceStr);

            Console.WriteLine("Скидка в %:");
            string salePriceStr = Console.ReadLine();
            int salePrice = int.Parse(salePriceStr);

            Console.WriteLine("Стоимость отпуска:");
            string holidayPriceStr = Console.ReadLine();
            int holidayPrice = int.Parse(holidayPriceStr);
            
            if ((normPrice * salePrice / 100.0)>0) 
            {
                double bottles = (holidayPrice / (normPrice * salePrice / 100.0));
                int countbottles = (int)(bottles);
                Console.WriteLine($"{countbottles} бутылок виски придется купить");

            }

            else
            {
                Console.WriteLine("Скидка не может быть 0");
            }



            //6

            Console.WriteLine("6)");
            Console.WriteLine("Создать структуру студента.");

            



        }
            



    }

    

}