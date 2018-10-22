using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Lab1
{
    //Класс для чистой функии
    public class Function
    {
        //Делегат функции
        private Func<double, double> _func;

        //Конструктор
        public Function(Func<double, double> func)
        {
            this._func = func;
        }

        //Вычисляет значение функции по аргументу
        public double Caclulate(double arg) => _func(arg);
    }
}
