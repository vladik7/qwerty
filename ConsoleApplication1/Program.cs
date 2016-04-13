<<<<<<< HEAD
﻿namespace ConsoleApplication1
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1400:AccessModifierMustBeDeclared", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
    class Program
    {
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
        static void Main()
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var c = Console.ReadLine();
            double a1 = 0;
=======
﻿// Все юзинги пишутся внутри namespace.

using System;

// То, что серым цветом - это код, который никак не используется.
// В данном случае подключения пространств имен, классы из которых мы не используем.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    // У класса всегда должен быть модификатор доступа
    class Program
    {
        // У метода тоже. Не знаешь какой ставить - тебе подскажет решарпер.
        static void Main(/*неиспользуемые аргументы метода*/string[] args)
        {
           var a = Console.ReadLine();
           var b = Console.ReadLine();
           var c = Console.ReadLine();
            double a1 = 0; 
>>>>>>> 244ac097cb37ea16af36d10252a85a6f50b02e29
            double b1 = 0;
            double c1 = 0;
            if (double.TryParse(a, out a1) && double.TryParse(b, out b1) && double.TryParse(c, out c1))
            {

<<<<<<< HEAD
                var d = b1 * b1 - 4 * a1 * c1;
=======
                // Стайлкоп требует явного указания приоритетов операций с помощью скобок.
                // Ну правда тут он вступает в конфликт с решарпером, у которого свое мнение на этот счет. Так что злоупотреблять скобками тоже не стоит

                // Вычисление дискриминанта будет необязательным, если какие-то из коэффициенто будут равны нулям. Обработать эти случаи тоже.
                double d = b1 * b1 - 4 * a1 * c1;
>>>>>>> 244ac097cb37ea16af36d10252a85a6f50b02e29
                if (d >= 0)
                {
                    if (d > 0)
                    {
<<<<<<< HEAD
                        var x1 = (-b1 + Math.Pow(d, 0.5)) / (2 * a1);
                        var x2 = (-b1 - Math.Pow(d, 0.5)) / (2 * a1);
                        Console.WriteLine("x1 = {0}", x1);
                        Console.WriteLine("x2 = {0}", x2);
=======
                        double x1 = (-b1+Math.Pow(d,0.5))/(2*a1); // Всегда все операторы и операнды разделяется пробелами
                        double x2 = (-b1 - Math.Pow(d, 0.5)) / (2 * a1); // предпочтительнее использовать неявную типизацию, то есть ключевое слово var
                        Console.WriteLine("x1 = {0}",x1); // пробелы
                        Console.WriteLine("x2 = {0}",x2);
>>>>>>> 244ac097cb37ea16af36d10252a85a6f50b02e29
                    }
                    else
                    {
                        double x1 = (-b1 + Math.Pow(d, 0.5)) / (2 * a1);
                        Console.WriteLine("x1 = x2 = {0}", x1);
                    }
                }
                else
                {
<<<<<<< HEAD
                    Console.WriteLine("Корней нет");
=======
                    Console.WriteLine("Kornei net"); // Забудь про транслит. Либо пиши уж на русском(только в интерфейсе и пользовательском выводе), либо на английском.
>>>>>>> 244ac097cb37ea16af36d10252a85a6f50b02e29
                }
            }
            else
            {
                Console.WriteLine("Введите числа");
            }
        }
    }
}
