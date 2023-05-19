using Dotnet_Tipos_Especiais.Models;
using Newtonsoft.Json;
string conteudoArquivo = File.ReadAllText("Arquivos/listaVendas.json");
List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

var listaAnonimo = listaVendas.Select(x=> new{x.Produto,x.Preco,x.Desconto} );

foreach (var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}, Desconto: {venda.Desconto}");
}