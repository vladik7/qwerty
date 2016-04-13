namespace ConsoleApplication1
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
            double b1 = 0;
            double c1 = 0;
            if (double.TryParse(a, out a1) && double.TryParse(b, out b1) && double.TryParse(c, out c1))
            {

                var d = b1 * b1 - 4 * a1 * c1;
                if (d >= 0)
                {
                    if (d > 0)
                    {
                        var x1 = (-b1 + Math.Pow(d, 0.5)) / (2 * a1);
                        var x2 = (-b1 - Math.Pow(d, 0.5)) / (2 * a1);
                        Console.WriteLine("x1 = {0}", x1);
                        Console.WriteLine("x2 = {0}", x2);
                    }
                    else
                    {
                        double x1 = (-b1 + Math.Pow(d, 0.5)) / (2 * a1);
                        Console.WriteLine("x1 = x2 = {0}", x1);
                    }
                }
                else
                {
                    Console.WriteLine("Корней нет");
                }
            }
            else
            {
                Console.WriteLine("Введите числа");
            }
        }
    }
}
