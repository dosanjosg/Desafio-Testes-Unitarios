using TestesUnitariosConsole.Services;

namespace TestesUnitariosTests
{
    public class ValidacoesListaTests
    {
        private ValidacoesLista _validacoes;
        public ValidacoesListaTests()
        {
            _validacoes = new ValidacoesLista();
        }

        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista() 
        {
            List<int> numeros = [-5, -2, 0, 3, 7, -1, 4];

            List<int> resultadoEsperado = [0, 3, 7, 4];

            List<int> positivos = _validacoes.RemoverNumerosNegativos(numeros);

            Assert.Equal(resultadoEsperado, positivos);
        }

        [Fact]
        public void DeveConterONumero9NaLista() 
        {
            List<int> numeros = [-5, -2, 0, 3, 7, 9, 4];

            int numero = 9;

            bool resultado = _validacoes.ListaContemDeterminadoNumero(numeros, numero);

            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista()
        {
            List<int> numeros = [-5, -2, 0, 3, 7, 9, 4];

            int numero = 10;

            bool resultado = _validacoes.ListaContemDeterminadoNumero(numeros, numero);

            Assert.False(resultado);
        }

        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2() 
        {
            List<int> numeros = [-5, -2, 0, 3, 7, -1, 4];

            int valorMultiplicador = 2;

            List<int> listaEsperada = [-10, -4, 0, 6, 14, -2, 8];

            List<int> resultado = _validacoes.MultiplicarNumerosLista(numeros, valorMultiplicador);

            Assert.Equal(listaEsperada, resultado);
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista() 
        {
            List<int> numeros = [-5, -2, 0, 3, 9, -1, 4];

            int maiorNumero = 9;
            int resultado = _validacoes.RetornarMaiorNumeroLista(numeros);

            Assert.Equal(maiorNumero, resultado);  
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
        {
            List<int> numeros = [-8, -2, 0, 3, 7, -1, 4];

            int menorNumero = -8;
            int resultado = _validacoes.RetornarMenorNumeroLista(numeros);

            Assert.Equal(menorNumero, resultado);
        }
    }
}