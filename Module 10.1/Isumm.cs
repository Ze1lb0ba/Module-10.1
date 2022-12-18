using System.Threading;

namespace Module_10._1
{
    public interface Isumm
    {
        double Summ(double one, double two);
    }

    class Calculate : Isumm
    {
        Logger logger { set; get; }
        public double Summ(double one, double two)
        {
            logger = new Logger();
            double summ = one + two;
            logger.Event("Производится вычисление");
            Thread.Sleep(3000);
            logger.Event("Вычисления окончены");
            return summ;
        }
    }
}
