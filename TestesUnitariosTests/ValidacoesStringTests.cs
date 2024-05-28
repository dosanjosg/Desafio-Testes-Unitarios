

using TestesUnitariosConsole.Services;


namespace TestesUnitariosTests;

public class ValidacoesStringTests 
{
    private ValidacoesString _validacoes;

    public ValidacoesStringTests()
    {
        _validacoes = new ValidacoesString();
    }

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        //Arrange
        string texto = "Matrix";

        //Act
        int resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        //Assert
        Assert.Equal(6, resultado);
    }
    
    [Fact]
    public void DeveConterAPalavraQualquerNoTexto()
    {
        string texto = "Esse é um texto qualquer";
        string palavra = "qualquer";

        bool resultado = _validacoes.ContemCaractere(texto, palavra);

        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        string texto = "Esse é um texto qualquer";
        string palavra = "teste";

        bool resultado = _validacoes.ContemCaractere(texto, palavra);

        Assert.False(resultado);
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurada()
    {
        string texto = "Começo, meio e fim do texto procurado";
        string trecho = "procurado";

        bool resultado = _validacoes.TextoTerminaCom(texto, trecho);

        Assert.True(resultado);
    }
}