using System;
using System.Numerics;


namespace v2
{
    class Program
    {
        static void Main(string[] args)
        {
            ebanoeKakTwoyMatMenu();
        }
        static void ebanoeKakTwoyMatMenu()
        {
            while (true)
            {
                Console.WriteLine("Сгенерировать=1 Умножить=2 Выйти=3");
                int vibor = int.Parse(Console.ReadLine());
                int min, max;
                switch (vibor)
                {
                    case 1:
                        Console.WriteLine("Сгенерировать по длинне=1 Сгенерировать по мин и макс =2  Сгенерировать без ограничнений=3  ");
                        vibor = int.Parse(Console.ReadLine());
                        switch (vibor)
                        {
                            case 1:
                                Console.WriteLine("Укажите длинну ");
                                vibor = int.Parse(Console.ReadLine());
                                Console.WriteLine(ClassLibrary1.Generate.getRandom(vibor) + "\n");
                                break;
                            case 2:
                               
                                Console.WriteLine("Укажите мин ");
                                min = int.Parse(Console.ReadLine());
                                Console.WriteLine("Укажите макс ");
                                max = int.Parse(Console.ReadLine());
                               Console.WriteLine( ClassLibrary1.Generate.getRandom(min,max) + "\n");
                                break;
                            case 3:
                                Console.WriteLine(ClassLibrary1.Generate.getRandom() + "\n");
                                break;
                            default: continue;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Умножить заданные ваши простые числа=1,Сгенерировать и умножить =2 ");
                        vibor = int.Parse(Console.ReadLine());
                        switch (vibor)
                        {
                            case 1:
                                Console.WriteLine("Укажите число 1 ");
                                min = int.Parse(Console.ReadLine());
                                Console.WriteLine("Укажите число 2 ");
                                max = int.Parse(Console.ReadLine());
                                Console.WriteLine(ClassLibrary1.Sravnisuka.sravnisuka(min, max) + "\n");
                                break;
                            case 2:
                                Console.WriteLine(ClassLibrary1.Sravnisuka.sravnisuka()+"\n");
                                break;
                            default: continue;
                        }
                        break;
                    case 3:
                        return;
                    default: continue;
                }
            }
        }
        

    }
}
