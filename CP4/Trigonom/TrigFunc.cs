using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP4.Trigonom
{
    public class TrigFunc
    {
        public static double Factorial(uint num)
        {
            if (num <= 1)
            {
                return 1d;
            }

            return num * Factorial(num - 1);
        }

        /// <summary>
        /// Рекурсивный метод возведения в степень
        /// </summary>
        /// <param name="num">Число</param>
        /// <param name="pow">Степень</param>
        /// <returns>Результат</returns>
        public static double Power(double num, int pow)
        {
            if (pow == 0)
            {
                return 1;
            }

            return num * Power(num, pow - 1);
        }

        /// <summary>
        /// Модуль числа
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Абсолютное значение числа</returns>
        public static double Abs(double num)
        {
            if (num >= 0)
            {
                return num;
            }

            return -num;
        }

        /// <summary>
        /// Рекурсивный метод вычисления sin(x)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <param name="precision">Точность</param>
        /// <returns>Результат</returns>
        public static double Sin(double x, int n = 0, double precision = 1e-10)
        {
            var t = Power(-1, n) * Power(x, 2 * n + 1) / Factorial((uint)(2 * n + 1));
            if (Abs(t) < precision)
            {
                return t;
            }

            return t + Sin(x, n + 1, precision);
        }
        public static double Cos(double x, int n = 0, double precision = 1e-10)
        {
            var t = Power(-1, n) * Power(x, 2 * n) / Factorial((uint)(2 * n));
            if (Abs(t) < precision)
            {
                return t;
            }

            return t + Cos(x, n + 1, precision);
        }
        public double CoSec(double x)
        {
            return 1 / Sin(x);
        }
        public static double CoTan(double x)
        {
            return Cos(x) / Sin(x);
        }
        private static double Sum(double x, int n = 1, double precision = 1e-10)
        {
            var current = Power(x, n) / n;
            if (current < precision)
            {
                return current;
            }

            return current + Sum(x, n + 1, precision);
        }

        /// <summary>
        /// Метод вычисления ln(1-x)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="precision">Точность</param>
        /// <returns>Результат</returns>
        public static double Lnxx(double x, double precision = 1e-10)
        {
            return -Sum(x, precision: precision);
        }
    }
}
