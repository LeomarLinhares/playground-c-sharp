using System;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {
            Pessoa _1 = new Pessoa();
            Pessoa _2 = new Pessoa();

            Console.WriteLine("Informe os dados da primeira pessoa");
            _1.Nome = Console.ReadLine();
            _1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe os dados da segunda pessoa");
            _2.Nome = Console.ReadLine();
            _2.Idade = int.Parse(Console.ReadLine());

            string pessoaMaisVelha = MaisVelha(_1, _2);

            Console.WriteLine($"{_1.Nome} tem {_1.Idade} anos e {_2.Nome} tem {_2.Idade} anos. Logo {pessoaMaisVelha}.");
        }

        static string MaisVelha(Pessoa pessoa1, Pessoa pessoa2) {
            if (pessoa1.Idade == pessoa2.Idade) {
                return "ambos tem a mesma idade";
            }
            else if (pessoa1.Idade > pessoa2.Idade) {
                return $"{pessoa1.Nome} é mais velho";
            }
            else {
                return $"{pessoa2.Nome} é mais velho";
            }
        }
    }
}