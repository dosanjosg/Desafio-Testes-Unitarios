namespace TestesUnitariosConsole.Services 
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres (string texto) 
        {
            int qtdCaracteres = texto.Count();

            return qtdCaracteres;
        }

        public bool ContemCaractere (string texto, string palavra) 
        {
            return texto.Contains(palavra);
        }

        public bool TextoTerminaCom(string texto, string trecho) 
        {
            return texto.EndsWith(trecho);
        }
    }
}