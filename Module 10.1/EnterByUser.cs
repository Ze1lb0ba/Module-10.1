using System;

namespace Module_10._1
{
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
