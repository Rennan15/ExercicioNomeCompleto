string Nome, Sobrenome;

Console.Write("Escreva seu primeiro Nome:");
Nome=Console.ReadLine();

Console.Write("Escreva seu sobrenome:");
Sobrenome=Console.ReadLine();

Console.WriteLine($"{Nome} {Sobrenome}");
Console.WriteLine($"{Sobrenome.ToUpper()}, {Nome}");