namespace ValidaCamposConsole.Test
{
    public class ValidaCamposClasseDeTeste
    {
        [Theory]
        [InlineData("Joao")]
        [InlineData("Pedro")]
        [InlineData("Caio")]
        [InlineData("Jonas")]
        [InlineData("Gabi")]
        [InlineData("Manuelle")]
        [InlineData("Roberto")]
        [InlineData("Wagner")]
        public void ValidarNomeTeste(string nome)
        {   //Arranjar o teste
            //Executar a fun��o
            bool resultado = Validacoes.ValidarNome(nome);
          
            //Verificar o resultado da fun��o(Assert)
            Assert.True(resultado);
        }

        [Theory]
        [InlineData("")]
        [InlineData("Jo")]
        [InlineData(null)]
        [InlineData("12313")]
        [InlineData("1adg13")]
        public void ValidarNomeIncorreto(string nome)
        {
            //Executar a fun��o
            bool resultado = Validacoes.ValidarNome(nome);

            //Verificar o resultado da fun��o(Assert)
            Assert.False(resultado);
        }
    }
}