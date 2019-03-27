using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probabilidade
{
    // Classe para o cálculo de probabilidades.
    public class CalculaProbabilidade
    {
        // Método que tem como parâmetro a lista dos gols marcados pelo mandante e retorna a média.
        public decimal GolMarcadoMandante(List<int> golsMarcados)
        {
            // Declara tipo inteiro para armazenar o valor total de gols.
            int totalGols = 0;
            // Declara tipo decimal para armazenar a média de gols marcados do mandante.
            decimal mediaGolsMarcadosMandante = 0;

            // Instrução para somar os resultados da lista.
            foreach (int item in golsMarcados)
            {
                // Soma, atribui à totalGols.
                totalGols += item;
            }

            // Atribui à variável, a média ou seja, a soma dividido pelo número de resultados.
            mediaGolsMarcadosMandante = (decimal)totalGols / (decimal)golsMarcados.Count;

            // Retorna a média dos gols marcados do mandante.
            return mediaGolsMarcadosMandante;

            // Fim da classe GolMarcadoMandante.
        }

        // Método que tem como parâmetro a lista dos gols sofridos pelo visitante e retorna a média.
        public decimal GolMarcadoVisitante(List<int> golsMarcados)
        {
            // Declara tipo inteiro para armazenar o valor total de gols.
            int totalGols = 0;
            // Declara tipo decimal para armazenar a média de gols marcados do visitante.
            decimal mediaGolsMarcadosVisitante = 0;

            // Instrução para somar os resultados da lista.
            foreach (int item in golsMarcados)
            {
                // Soma, atribui à totalGols.
                totalGols += item;
            }

            // Atribui à variável, a média ou seja, a soma dividido pelo número de resultados.
            mediaGolsMarcadosVisitante = (decimal)totalGols / (decimal)golsMarcados.Count;

            // Retorna a média dos gols marcados do visitante.
            return mediaGolsMarcadosVisitante;

            // Fim da classe GolMarcadoVisitante.
        }

        // Método que tem como parâmetro a lista dos gols sofridos pelo mandante e retorna a média.
        public decimal GolSofridoMandante(List<int> golsSofridos)
        {
            // Declara tipo inteiro para armazenar o valor total de gols.
            int totalGols = 0;
            // Declara tipo decimal para armazenar a média de gols sofridos do mandante.
            decimal mediaGolsSofridosMandante = 0;

            // Instrução para somar os resultados da lista.
            foreach (int item in golsSofridos)
            {
                // Soma, atribui à totalGols.
                totalGols += item;
            }

            // Atribui à variável, a média ou seja, a soma dividido pelo número de resultados.
            mediaGolsSofridosMandante = (decimal)totalGols / (decimal)golsSofridos.Count;

            // Retorna a média dos gols marcados do mandante.
            return mediaGolsSofridosMandante;

            // Fim da classe GolSofridoMandante.
        }

        // Método que tem como parâmetro a lista dos gols sofridos pelo visitante e retorna a média.
        public decimal GolSofridoVisitante(List<int> golsSofridos)
        {
            // Declara tipo inteiro para armazenar o valor total de gols.
            int totalGols = 0;
            // Declara tipo decimal para armazenar a média de gols sofridos do visitante.
            decimal mediaGolsSofridosVisitante = 0;

            // Instrução para somar os resultados da lista.
            foreach (int item in golsSofridos)
            {
                // Soma, atribui à totalGols.
                totalGols += item;
            }

            // Atribui à variável, a média ou seja, a soma dividido pelo número de resultados.
            mediaGolsSofridosVisitante = (decimal)totalGols / (decimal)golsSofridos.Count;

            // Retorna a média dos gols marcados do mandante.
            return mediaGolsSofridosVisitante;

            // Fim da classe GolSofridoVisitante.
        }

        // Método para calcular a distribuição de Poisson que usa como parâmetros o lambda e 0, 1, 2, 3 ou 4 gols.
        public double calculaPoisson(double lambda, double gol)
        {
            // Declara um tipo double para armazenar o resultado e atribui valor zero.
            double resultadoPoisson = 0;


            // Declara um tipo double para o valor do fatorial.
            double fatorial = 0;

            // Instrução para o fatorial de 0, 1, 2, 3 e 4.
            // Se for zero.
            if (gol == 0)
            {
                // Atribui valor 1.
                fatorial = 1;
            }

            // Senão, se for 1.
            else if (gol == 1)
            {
                // Atribui valor 1.
                fatorial = 1;
            }

            // Senão, se for 2.
            else if (gol == 2)
            {
                // Atribui valor 2.
                fatorial = 2;
            }

            // Senão, se for 3.
            else if (gol == 3)
            {
                // Atribui valor 6.
                fatorial = 6;
            }

            // Senão, se for 4.
            else if (gol == 4)
            {
                // Atribui valor 24.
                fatorial = 24;
            }

            // Atribui a distribuição de Poisson com os parâmetros de lambda e gol no tipo decimal resultadoPoisson.
            resultadoPoisson = Math.Pow(Math.E, -lambda) * Math.Pow(lambda, gol) / fatorial;

            // Retorno do método com o resultado.
            return resultadoPoisson;

            // Fim da classe calculaPoisson
        }

        // Fim da classe CalculaProbabilidade
    }
}
