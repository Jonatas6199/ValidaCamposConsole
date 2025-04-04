﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaCamposConsole
{
    public static class Validacoes
    {
        public static bool ValidarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome) ||
                nome.Length < 3 ||
                nome.Any(char.IsDigit))
                return false;
            else
                return true;
        }
        public static bool ValidarDataNascimento(string dataNascimento) 
        {
            DateTime dataNascimentoAValidar;
            DateTime.TryParse(dataNascimento, out dataNascimentoAValidar);

            if(dataNascimentoAValidar == DateTime.MinValue
                || dataNascimentoAValidar > DateTime.Now)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
