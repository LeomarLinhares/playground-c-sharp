using System;
using System.Globalization;
using PrimeiroProjeto.ExercicioDeClasseEstatica;

namespace PrimeiroProjeto {
    internal class Program {
        private static List<string> programasDisponiveis = new List<string>();
        static void Main(string[] args) {
            // disponibilizar programas
            programasDisponiveis.Add("conversor de moeda");
            programasDisponiveis.Add("brincando com construtores");

            while (true) {
                Console.Write("Qual programa você deseja iniciar: ");
                string programa = Console.ReadLine();

                // relacionar programas às suas chamadas 
                if (programa == "conversor de moeda") { InicializarConversorDeMoeda(); }
                else if (programa == "brincando com construtores") { InicializarBrincandoComConstrutores(); }
                
                // apontar programas disponíveis
                else {
                    Console.WriteLine("Não existe esse programa, confira abaixo uma lista dos programas disponíveis:");
                    foreach (string item in programasDisponiveis) {
                        Console.WriteLine(" - " + item);
                    }
                }

                Console.WriteLine();
            }
        }

        // ----- CRIAR OS PROGRAMAS ----- //
        static void InicializarConversorDeMoeda() {
            Console.Write("Qual é a atual cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você quer comprar? ");
            double valorDesejado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorASerPago = ConversorDeMoeda.ComprarDolares(cotacao, valorDesejado);

            Console.WriteLine($"Baseado na cotação do dolar, o valor em reais a ser pago é {valorASerPago.ToString("F2")}");
        }

        static void InicializarBrincandoComConstrutores() {

        }
    }
}