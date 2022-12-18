using System;

namespace Module_10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    EnterByUser enter = new EnterByUser();
                    double result = enter.GetEnter();
                    Console.WriteLine("Сумма равна: " + result);
                    Console.WriteLine("");
                }

                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

    public interface Isumm
    {
        double Summ(double one, double two);
    }

    class Calculate : Isumm
    {
        public double Summ(double one, double two)
        {
            double summ = one + two;
            return summ;  
        }
    }

    class EnterByUser
    {
        public double GetEnter()
        {
            Calculate calc = new Calculate();
            Console.WriteLine("Введите первое число:");
            double one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double two = Convert.ToDouble(Console.ReadLine());
            double summ = calc.Summ(one, two);
            return summ;
        }
    }
}
