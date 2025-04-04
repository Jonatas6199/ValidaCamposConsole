using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaCamposConsole.Test
{
    public class ValidarOperacoesTestes
    {
        [Fact]
        public void TestarSomaTrue()
        {
            double resultado = Operacoes.Soma(3, 2);

            Assert.Equal(5, resultado);
        }

        [Theory]
        [InlineData(5, 2, 7)]
        [InlineData(3.5, 2, 5.5)]
        [InlineData(92, 2, 94)]
        [InlineData(-20, 10, -10)]
        public void TestarSomaTrueTheory(double valor1,
            double valor2,
            double resultado)
        {
            double soma = Operacoes.Soma(valor1, valor2);

            Assert.Equal(resultado, soma);
        }
    }
}
