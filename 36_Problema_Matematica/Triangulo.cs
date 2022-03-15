 using System;

namespace _36_Problema_Matematica {
    class Triangulo {
        public double a;
        public double b;
        public double c;
        
        public double Area() {

            double p = (a + b + c) / 2;
            //Raiz
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
            
        }

    }
}
