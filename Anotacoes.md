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
* ideal para retorno de informações do banco de dados
```csharp

    using Dotnet_Tipos_Especiais.Models;
    using Newtonsoft.Json;
    string conteudoArquivo = File.ReadAllText("Arquivos/listaVendas.json");
    List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

    var listaAnonimo = listaVendas.Select(x=> new{x.Produto,x.Preco,x.Desconto} );

    foreach (var venda in listaAnonimo)
    {
        Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}, Desconto: {venda.Desconto}");
    }

```
## Tipo dinâmico
* cuidado ao usar pois se colocar o tipo errado pode receber uma exceção
```csharp
    dynamic variavelDinamica = 4;
    Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
    variavelDinamica = "Texto";
    Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
    variavelDinamica = true;
    Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
```
## Classe Genérica
* As classes genéricas encapsulan operações que não são específicas de um determinado tipo de dados.
```csharp
   MeuArray<int> arrayInteiro = new MeuArray<int>();
   arrayInteiro.AdicionarElementoArray(30);
   Console.WriteLine(arrayInteiro[0]);
```
## Métodos de extensão
* Os métodos de extensão permitem que você adicione tipos existentes sem criar um novo tipo derivado, recompilar ou , caso contrário, modificar o tipo original
* Extende o comportamento do inteiro `this int`

```csharp
    using Dotnet_Tipos_Especiais.Models;
    int numero = 20;
    bool par = false;

    par = numero.EhPar();

    string mensagem = "O número " + numero + " é " + (par ? "Par": "Impar");
    Console.WriteLine(mensagem);
```