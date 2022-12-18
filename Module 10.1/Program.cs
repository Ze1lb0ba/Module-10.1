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
                    Logger logger = new Logger();
                    logger.Error(ex.Message);
                }

                catch (FormatException ex)
                {
                    Logger logger = new Logger();
                    logger.Error(ex.Message);
                }
            }
        }
    }
}
