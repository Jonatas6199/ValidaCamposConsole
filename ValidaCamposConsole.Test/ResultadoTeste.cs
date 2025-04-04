using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaCamposConsole.Test
{
    public class ResultadoTeste
    {
        public string Nome { get; set; }
        public string Parametro { get; set; }

        public StatusTesteEnum Resultado { get; set; }

        public double TempoDeExecucao { get; set; }
    }
}
