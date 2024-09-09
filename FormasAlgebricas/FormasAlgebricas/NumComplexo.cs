using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumComplexoApp
{
    class NumComplexo
    {
        public double Real { get; private set; }
        public double Imaginario { get; private set; }

        public NumComplexo(double real, double imaginario)
        {
            Real = real;
            Imaginario = imaginario;
        }

        public NumComplexo Soma(NumComplexo outro)
        {
            return new NumComplexo(this.Real + outro.Real, this.Imaginario + outro.Imaginario);
        }

        public NumComplexo Vezes(NumComplexo outro)
        {
            double novoReal = (this.Real * outro.Real) - (this.Imaginario * outro.Imaginario);
            double novoImaginario = (this.Real * outro.Imaginario) + (this.Imaginario * outro.Real);
            return new NumComplexo(novoReal, novoImaginario);
        }

        public double Modulo()
        {
            return Math.Sqrt(Real * Real + Imaginario * Imaginario);
        }

        public double Argumento()
        {
            return Math.Atan2(Imaginario, Real);
        }

        public void ImprimeFormaPolar()
        {
            double modulo = Modulo();
            double argumento = Argumento();
            Console.WriteLine($"Forma Polar: {modulo} (cos({argumento}) + i*sin({argumento}))");
        }
    }
}