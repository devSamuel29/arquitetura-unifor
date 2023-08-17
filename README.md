# Explicação
- Basicamente fiz um MVC implementando os conceitos do SOLID, não fiz nada muito complexo.

## Classes
- A regra de negócio toda é chamada a partir da minha controller (na pasta ./Controllers/PizzariaController.cs). Nela é utilizado o conceito de injenção de depêndecia via contrutor, a inversão de dependecia é declarada em ./Program.cs. Ambas seguem o principio S e L do SOLID:

```csharp
    // Scoped é a regra de criação de instacias, nesse caso a cada requisição HTTP é criada uma nova instância
    builder.Services.AddScoped<IFazerPizza, FazerPizzaRepository>();
    builder.Services.AddScoped<IFazerPagamento, FazerPagamentoRepository>();
```

- Para melhor organização, criei uma pasta Repository, lá é a implementação da minha regra de negócio.

- Também pensando em organização, criei objetos para Request e Response, caso queira verifica está em ./Request ou ./Response.

- 

# Caso queira testar:
- Instalar a CLI do dotnet: https://dotnet.microsoft.com/pt-br/download (.NET 7.0);
- Ir na IDE que desejar, vou assumir que o senhor use o vscode;
- Apertar CTRL + J;
- Digitar dotnet run
- Quando rodar, provalvemente, é na porta 5000;
- Pra facilitar, no link: localhost:5000, o senhor adiciona /swagger -> localhost:5000/swagger.
