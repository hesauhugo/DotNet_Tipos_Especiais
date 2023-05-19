using Dotnet_Tipos_Especiais.Models;
int numero = 20;
bool par = false;

par = numero.EhPar();

string mensagem = "O número " + numero + " é " + (par ? "Par": "Impar");
Console.WriteLine(mensagem);
