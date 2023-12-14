using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5WF
{
    internal class Conversor
    {
        private double cd;
        private double d;

        public Conversor (double cd, double d)
        {
            this.cd = cd;
            this.d = d;
        }

        public Conversor ()
        {
            this.cd = 0;
            this.d = 0;
        }

        public void Setcd (double dolar)
        {
            this.cd = dolar;
        }

        public void SetDigitar (double digitar)
        {
            this.d = digitar;
        }

        public double Getcd ()
        {
            return this.cd;
        }

        public double GetDigitar ()
        {
            return this.d;
        }

        public double ConverterParaReais()
        {
          return d * cd;
        }
    }
}
