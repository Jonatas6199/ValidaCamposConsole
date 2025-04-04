using ValidaCamposConsole;

Console.WriteLine("Digite um nome:");
string nome = Console.ReadLine();

bool valido = Validacoes.ValidarNome(nome);

if (valido)
    Console.WriteLine("Nome Válido");
else
    Console.WriteLine("Nome inválido");

Console.WriteLine("Escreva uma data de nascimento");
string data = Console.ReadLine();

bool dataValida = Validacoes.ValidarDataNascimento(data);

if (dataValida)
    Console.WriteLine("Data válida");
else
    Console.WriteLine("Data inválida");