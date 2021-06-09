using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool temp = MidTemp();
            bool month = MonthNumber();
            ParityNumber();
            CheckOutput();
            //Задание 5
            if (temp && month)
            {
                Console.WriteLine("Дождливая зима");
            }
            DaysWeek();
        }
        //Задание 1
        private static bool MidTemp()
        {
            Console.WriteLine("Введите минимальную температуру");
            double tMin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру");
            double tMax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Среднесуточная температура: {(tMin + tMax) / 2}");

            if ((tMin + tMax) / 2 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //Задание 2
        private static bool MonthNumber()
        {
            Console.WriteLine("Введите номер месяца");
            Month now = (Month)int.Parse(Console.ReadLine());
            Console.WriteLine($"Месяц: {now}");
            if (now == (Month)12 || now == (Month)1 || now == (Month)2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        enum Month
        {

            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
        //Задание 3
        private static void ParityNumber()
        {
            Console.WriteLine("Введите число для проверки на четность");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }
        }
        //Задание 4
        private static void CheckOutput()
        {
            DateTime date1 = new DateTime(17, 6, 14, 20, 19, 0);

            byte zero = 0;
            byte one = 1;

            char StringSymbol = '#';
            char number = '№';
            char equally = '=';
            char percent = '%';

            string header = "____________ООО_СТРОЙ-ДИЗАЙН___________";
            string StringСheck1 = "KKM";
            string StringСheck2 = "ИНН";
            string StringСheck3 = "КАССИР";
            string StringСheck4 = "ПРОДАЖА";
            string StringСheck5 = "ВКЛЮЧАЯ_НАЛОГИ";
            string StringСheck6 = "НДС";
            string StringСheck7 = "СУММ._НАЛОГ";
            string StringСheck8 = "ИТОГ";
            string StringСheck9 = "НАЛИЧНЫМИ";
            string StringСheck10 = "ЭКЛЗ";

            int numbers1 = 645455;
            long numbers2 = 7802174043;
            short numbers3 = 2743;
            short numbers4 = 2998;
            short numbers5 = 9050;
            byte numbers6 = 18;
            double numbers7 = 1380.51;
            uint numbers8 = 1415660824;
            int numbers9 = 76431;
            int numbers10 = 740670;

            Console.WriteLine($"{header}");
            Console.WriteLine($"{StringСheck1}__{zero}{zero}{numbers1}_____{StringСheck2}__{zero}{zero}{numbers2}___{StringSymbol}{numbers3}");
            Console.WriteLine($"{date1}_______________{StringСheck3}__{one}");
            Console.WriteLine($"{StringСheck4}_______________________________{number}{numbers4}");
            Console.WriteLine($"{zero}{one}____________________________________{equally}{numbers5}");
            Console.WriteLine($"{StringСheck5}_____________________________");
            Console.WriteLine($"{StringСheck6}__{numbers6}{percent}___________________________{equally}{numbers7}");
            Console.WriteLine($"{StringСheck7}________________________{equally}{numbers7}");
            Console.WriteLine($"{StringСheck8}__________________________________{equally}{numbers5}");
            Console.WriteLine($"{StringСheck9}_____________________________{equally}{numbers5}");
            Console.WriteLine($"__________________________{StringСheck10}___{numbers8}");
            Console.WriteLine($"_________________________{zero}{zero}{zero}{numbers9}___{StringSymbol}{numbers10}");
        }
        //Задание 6
        private static void DaysWeek()
        {
            days office1 = (days)0b_0111100;
            days office2 = (days)0b_1111111;
            days officeAll = office1 & office2;
            Console.WriteLine($"Офиc 1 работает по дням: {office1}\nОфис 2 работает по дням: {office2}\n Дни, которые работают оба офиса: {officeAll}");
        }
        [Flags]
        enum days
        {
            monday = 0b_1000000,
            tuesday = 0b_0100000,
            wednesday = 0b_0010000,
            thursday = 0b_0001000,
            friday = 0b_0000100,
            saturday = 0b_0000010,
            sunday = 0b_0000001
        }
    }
}
