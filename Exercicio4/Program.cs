using System;
class Program{
    static void Main(){
        const double SP = 67836.43;
        const double RJ = 36678.66;
        const double MG = 29229.88;
        const double ES = 27165.48;
        const double outros = 19849.53;

        var total = SP + RJ + MG + ES + outros;
        Console.WriteLine("Percentual SP: "+Percentual(SP,total)+"%");
        Console.WriteLine("Percentual RJ: "+Percentual(RJ,total)+"%");
        Console.WriteLine("Percentual MG: "+Percentual(MG,total)+"%");
        Console.WriteLine("Percentual ES: "+Percentual(ES,total)+"%");
        Console.WriteLine("Percentual Outros: "+Percentual(outros,total)+"%");

    }
    private static double Percentual(double valor, double total){
        var porcento = (100 * valor) / total;
        return Math.Round(porcento,2);
    }
}
