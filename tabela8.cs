using System;

namespace Tabela8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double valorInvestido = 10000.00; 
            double taxaJuros = 1.25;      
            int periodoTotalMeses = 6;      

            
            Console.WriteLine("Valor Investido | Taxa de Juros | Rendimento | Período (a.m.) | Resgate   | Saldo Líquido");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            double saldoAtual = valorInvestido;

           
            for (int mes = 1; mes <= periodoTotalMeses; mes++)
            {
              
                double rendimentoDoMes = saldoAtual * (taxaJuros / 100);
                saldoAtual = saldoAtual + rendimentoDoMes;

                double valorResgate = 0.0;

                
                if (mes == 5)
                {
                 
                    valorResgate = saldoAtual - valorInvestido;
                    saldoAtual = valorInvestido;
                }

                
                Console.WriteLine($"R$ {valorInvestido,-12:F2} | {taxaJuros,-11:F2}% | R$ {rendimentoDoMes,-10:F2} | Mes {mes,-10} | R$ {valorResgate,-9:F2} | R$ {saldoAtual,-12:F2}");
            }

            Console.WriteLine("---------------------------------------------------------------------------------------");
        }
    }
}