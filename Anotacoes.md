## Nulo
* Um tipo de valor nulo permite representar o tipo da variável e adicionalmente, o valor nulo.
```csharp
    bool  = true, false
    bool? = true, false, null
```

* Implementando
* Usar HasValue sempre quando usar tipos nulos

```csharp
    bool? desejaReceberEmail = true;
    if(desejaReceberEmail.HasValue && desejaReceberEmail.Value){
        Console.WriteLine("O usuário optou por receber o e-mail");
    }else{
        Console.WriteLine("O usuário não respondeu ou optou por não receber o e-mail");
    }
```
## Tipos de Nulo em propriedades
* Implementando 
```csharp
    using Dotnet_Tipos_Especiais.Models;
    using Newtonsoft.Json;

    var conteudoArquivo = File.ReadAllText("Arquivos/listaVendas.json");
    List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);
    foreach (var venda in listaVendas)
    {
        Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Desconto: {(venda.Desconto.HasValue ? venda.Desconto.Value : "")}");
    }
```
## Tipo anonimo
* Muito semelhante a uma tupla
* Não pode retornar em métodos
```csharp
    var tipoAnonimo = new {Nome="Enzo", Sobrenome= "Gabriel", Altura = 1.95};
    Console.WriteLine($"Nome: {tipoAnonimo.Nome}");
    Console.WriteLine($"Sobrenome: {tipoAnonimo.Sobrenome}");
    Console.WriteLine($"Altura: {tipoAnonimo.Altura}");
```
## Tipo anonimo em coleção