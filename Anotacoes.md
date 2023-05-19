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
## Tipos de Nulo
