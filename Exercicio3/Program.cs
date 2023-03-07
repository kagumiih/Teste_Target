using System;
using Exercicio3;
using Newtonsoft.Json;
class Program{
static void Main(){

        string jsonString = File.ReadAllText($@"{Environment.CurrentDirectory}\dados.json");

        // Desserializar o JSON em um objeto C#
        var listadados = JsonConvert.DeserializeObject<List<Dados>>(jsonString);
        var dados = new Dados();
        
        Console.WriteLine("Maior valor: "+dados.MaiorValor(listadados));
        Console.WriteLine("Menor valor: "+dados.MenorValor(listadados));
        Console.WriteLine("Numero de dias: "+dados.ValorSuperior(listadados));
    }
}
