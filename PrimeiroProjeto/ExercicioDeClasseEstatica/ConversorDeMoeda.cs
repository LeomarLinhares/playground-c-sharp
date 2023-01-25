namespace PrimeiroProjeto.ExercicioDeClasseEstatica {
    class ConversorDeMoeda {
        private static float IOFPercentage = 0.06f;

        private static double ConverterParaReais(double valor, double cotacao) {
            return valor * cotacao;
        }

        public static double ComprarDolares(double valor, double cotacao) {
            double valorTotal = ConverterParaReais(valor, cotacao);
            return valorTotal * IOFPercentage + valorTotal;
        }
    }
}

// Essa classe é estática pois não possuí variação. Ela não é instanciável. Isso significa que ela não deve se alterar dependendo da instância.
