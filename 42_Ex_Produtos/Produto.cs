using System.Globalization;

namespace _42_Ex_Produtos {
    class Produto {

        public string Nome;
        public double Preco;
        public int Qtd;

        //Classe calculo
        public double Total() {
            return Qtd * Preco;

        }

        //sobreposição
        public override string ToString() {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + " , " + Qtd + " Unidades, Total " + Total().ToString("F2", CultureInfo.InvariantCulture);



        }

    }
}
