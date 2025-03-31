Console.WriteLine("-----Forca-----");
Console.WriteLine("Qual a palavra escolhida?");
string Palavra = Console.ReadLine()!;

Console.WriteLine("Qual a letra que você escolhe?");
string Letra = Console.ReadLine()!.Trim().Substring(0,1).ToLower();

bool LetraExiste = Palavra.ToLower().Contains(Letra);


Console.WriteLine($"A sua letra está na palavra escolhida? {LetraExiste}");

