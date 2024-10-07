using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pw_9
{
    class Shape
    {
        public virtual double GetArea()
        {
            return 0;
        }
        // Виртуальный метод для расчета периметра
        public virtual double GetPerimeter()
        {
            return 0;
        }
        public virtual double GetInfo() 
        {
            return 0;
        }
    }
}
