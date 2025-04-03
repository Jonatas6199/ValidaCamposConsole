// See https://aka.ms/new-console-template for more information
using ValidaCamposConsole;

Console.WriteLine("Digite um nome:");
string nome = Console.ReadLine();

bool valido = Validacoes.ValidarNome(nome);

if (valido)
    Console.WriteLine("Nome Válido");
else
    Console.WriteLine("Nome inválido");