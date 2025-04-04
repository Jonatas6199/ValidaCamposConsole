using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaCamposConsole.Test
{
    public static class Salvar
    {
        public static void SalvarResultadoTeste(ResultadoTeste resultado)
        {
            Thread.Sleep(50);
            string filePath = "Resultados.json";
            List<ResultadoTeste> resultados = new List<ResultadoTeste>();

            if (File.Exists(filePath))
            {
                string jsonExistente = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(jsonExistente))
                {
                    resultados = JsonConvert.DeserializeObject<List<ResultadoTeste>>(jsonExistente) ?? new List<ResultadoTeste>();
                }
            }
            resultados.Add(resultado);

            File.WriteAllText(filePath, JsonConvert.SerializeObject(resultados,Formatting.Indented));
        }
    }
}
