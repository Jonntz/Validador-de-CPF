
var valida = new Validador();

Console.WriteLine("Digite seu CPF: ");
string cpf = Console.ReadLine()!;

if (valida.validaCPF(cpf.ToString()))
{
  Console.WriteLine("CPF válido!");
} else
{
  Console.WriteLine("CPF Inválido!");
}
