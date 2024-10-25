using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhenger
{
    class kor
    {
        private double sugar,terulet,kerulet;

        public kor() { }

            public kor(double r)
            {
            sugar = r;
            }

        public void SetSugar(double r)
        {
            sugar = r;
        }

        public void SetTerulet()
        {
            this.terulet = Math.Round (Math.Pow(this.sugar, 2) * Math.PI);
        }

        public void SetKerulet()
        {
            this.kerulet = Math.Round ( 2 * this.sugar * Math.PI);
        }
        
        public double GetTerulet()
        {
            return this.terulet;
        }
        public double GetKerulet()
        {
            return this.kerulet;
        }

        public double GetSugar()
        {
            return this.sugar;
        }

    }
}
