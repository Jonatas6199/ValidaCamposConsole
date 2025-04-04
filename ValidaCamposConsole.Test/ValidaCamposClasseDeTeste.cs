using System.Diagnostics;

namespace ValidaCamposConsole.Test
{
    public class ValidaCamposClasseDeTeste
    {
        [Fact(Skip = "Teste em desuso temporariamente")]
        public void ValidarNomeTesteFact()
        {   //Arranjar o teste
            string nome = "Pedro";
            //Executar a função
            bool resultado = Validacoes.ValidarNome(nome);
            //Verificar o resultado da função(Assert)
            Assert.True(resultado);
        }

        [Theory(Skip ="Testando outros métodos")]
        [InlineData("Joao")]
        [InlineData("Manuelle")]
        [InlineData("Roberto")]
        [InlineData("Wagner")]
        public void ValidarNomeTeste(string nome)
        {
            bool resultado = Validacoes.ValidarNome(nome);
            Assert.True(resultado);
        }

        [Theory(Skip = "Testando outros métodos")]
        [InlineData("")]
        [InlineData("Jo")]
        [InlineData(null)]
        [InlineData("12313")]
        [InlineData("1adg13")]
        public void ValidarNomeIncorreto(string nome)
        {
            //Executar a função
            bool resultado = Validacoes.ValidarNome(nome);

            //Verificar o resultado da função(Assert)
            Assert.False(resultado);
        }

        [Theory(Skip ="Teste em pausa")]
        [InlineData("02/02/2012")]
        [InlineData("03/08/2013")]
        [InlineData("04/09/2014")]
        [InlineData("05/12/2015")]
        [InlineData("06/01/2016")]
        [InlineData("28/jan/2016")]
        public void ValidarDataNascimentoTrue(string dataNascimento) 
        {
            bool resultado = Validacoes.ValidarDataNascimento(dataNascimento);

            Assert.True(resultado);
        }

        [Theory(Skip ="Teste em pausa")]
        [InlineData("joao")]
        [InlineData("")]
        [InlineData("23/23/0001")]
        [InlineData("90/59/0001")]
        [InlineData("02/02/2026")]
        public void ValidarDataNascimentoFalse(string dataNascimento)
        {
            bool resultado = Validacoes.ValidarDataNascimento(dataNascimento);

            Assert.False(resultado);
        }


    }
}