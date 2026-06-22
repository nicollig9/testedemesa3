using System;

namespace Tabela6
{
    public class Investimento
    {
        public double ValorPresente { get; set; }
        public double TaxaJuros { get; set; }
        public int Meses { get; set; }
        public int Dias { get; set; }

        public Investimento(double valorPresente, double taxaJuros, int meses, int dias)
        {
            ValorPresente = valorPresente;
            TaxaJuros = taxaJuros;
            Meses = meses;
            Dias = dias;
        }

        public double CalcularTempoTotalEmMeses()
        {
            return Meses + (Dias / 30.0);
        }

        public double CalcularValorFuturo()
        {
            double tempoTotal = CalcularTempoTotalEmMeses();
            return ValorPresente * Math.Pow(1 + TaxaJuros, tempoTotal);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            double[] entradasValores = { 1000, 5500, 12000 };
            double[] taxas = { 0.03, 0.0248, 0.02 };
            int meses = 8;
            int dias = 10;

            Console.WriteLine(string.Format("{0,-15} | {1,-10} | {2,-15} | {3,-15}", "Valor Presente", "Taxa", "Tempo (Meses)", "Valor Futuro"));
            Console.WriteLine(new string('-', 60));

            for (int i = 0; i < entradasValores.Length; i++)
            {
                Investimento investimento = new Investimento(entradasValores[i], taxas[i], meses, dias);

                double valorFuturo = investimento.CalcularValorFuturo();
                double tempoTotal = investimento.CalcularTempoTotalEmMeses();

                Console.WriteLine(string.Format("{0,-15:C} | {1,-10:P2} | {2,-15:F4} | {3,-15:C}",
                    investimento.ValorPresente, investimento.TaxaJuros, tempoTotal, valorFuturo));
            }

            Console.ReadLine();
        }
    }
}