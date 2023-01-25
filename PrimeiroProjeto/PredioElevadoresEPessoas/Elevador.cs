namespace PrimeiroProjeto.PredioElevadoresEPessoas {
    internal class Elevador {
        public double Capacidade;
        public int Andar;
        public List<Tuple<Pessoa, int>> PessoasNoElevador;
        public bool EmMovimento = false;

        public Elevador(double capacidade) {
            Capacidade = capacidade;
        }

        public Elevador(double capacidade, int andar) : this(capacidade) {
            Andar = andar;
        }

        private List<Tuple<Pessoa, int>> PessoasEmOrdemDeIntencao() {

        }

        public void Entrar(Pessoa pessoa, int intencao) {
            Tuple<Pessoa, int> passageiro = Tuple.Create(pessoa, intencao);
            PessoasNoElevador.Add(passageiro);
        }

        public void Sair(Pessoa pessoa) {
            PessoasNoElevador.RemoveAll(p => p.Item1.Equals(pessoa));
        }

        public void Subir() {
            EmMovimento = true;
            // alterar o valor de Andar em um loop
            // no loop, comparar se existe algum passageiro com a intençao de sair naquele andar
            // se houver, alterar o EmMovimento para false e remover todos os passageiros da Lista PessoasNoElevador
        }
    }
}
