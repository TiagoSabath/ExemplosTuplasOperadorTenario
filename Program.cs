// ---- Tuple (Quando não precisar criar método)-------

(int ID, string Nome, string Sobrenome) tupla = (1, "Tiago", "Sabath");

ValueTuple<int, string, string> outroExemplo = (1, "Tiago", "Sabath"); // Outros Exemplos de tuplas
var outroExemploTuplaCreate = Tuple.Create(1, "Tiago", "Sabath");

Console.WriteLine($"ID: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");



// ---- Tuplas (Com método)-------

using ExemplosTuplasOperadorTenario.Models;

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhas, quantidadeLinhas) = arquivo.LerArquivo("Arquivo/arquivoLeitura.txt"); //(sucesso, linhas, _) Usar ( _ ) quando nao usar a informação

if (sucesso)
{
    Console.WriteLine("Quantidade de linhas: " + quantidadeLinhas);
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}



// ---- If Ternário -------

int numero = 10;
bool ehPar = false;

ehPar = numero % 2 == 0;

Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));
