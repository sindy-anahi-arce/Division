using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_1
{
    class clDivi
    {
        //Atributos
        private float num1;
        private float num2;

        //Constructor(Es el que dirige)
        public clDivi(float num1, float num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        //Método
        public float division()
        {
            return (num1 / num2);
        }
    }
}
