namespace TestesUnitariosConsole.Services 
{
    public class ValidacoesLista
    {
        public List <int> RemoverNumerosNegativos(List<int> numeros) 
        {
            return numeros.Where(n => n >= 0).ToList();
        } 
        
        public bool ListaContemDeterminadoNumero(List<int> numeros, int numero) 
        {
            return numeros.Contains(numero);
        }
         
        
        public List <int> MultiplicarNumerosLista(List<int> numeros, int numero) 
        {
            List <int> novaLista = [];

            foreach(var num in numeros) 
            {
                novaLista.Add(num * numero);
            }

            return novaLista;
        }
        
        public int RetornarMaiorNumeroLista(List<int> numeros) 
        {
            int maiorNumero = numeros.Max();
            return maiorNumero;
        }

        public int RetornarMenorNumeroLista(List<int> numeros) 
        {
            int menorNumero = numeros.Min();

            return menorNumero;
        }
    }
}