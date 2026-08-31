using System.Net.Http.Headers;

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();

p1.Nome = "Ester Correa";
p1.Idade = 16;
p1.Endereco = "Aririu";

p2.Nome = "Livia Tanese";
p2.Idade = 15;
p2.Endereco = "Guarda City";

p1.ExibirInfor();
Console.WriteLine(); //Separar bonitinho
p2.ExibirInfor();
Console.WriteLine(); //Separar bonitinho
p1.Saudar();