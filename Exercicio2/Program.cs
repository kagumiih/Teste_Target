using System;
class Program{
    static void Main(){
        var valor = RecebeValor();
        if(VerificaFibonacci(valor)){
            Console.WriteLine("Pertence a sequência.");
            var sequencia = CalcularSequencia(valor);
            foreach(var s in sequencia){
                Console.Write(s);
            }
        }else{
            Console.WriteLine("Não pertence a sequência.");
        }
    }
    public static int RecebeValor(){
        Console.WriteLine("Digite um valor: ");
        var num = Console.ReadLine();
        return int.Parse(num);
    }
    
    public static bool VerificaFibonacci(int num){
        int a = 0, b = 1;

        while (b < num)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }
        return b == num || num == 0;
    }

    public static List<int> CalcularSequencia(int num){
        List<int> sequence = new List<int>();
        int a = 0, b = 1;

        while (a <= num)
        {
            sequence.Add(a);
            int temp = b;
            b = a + b;
            a = temp;
        }
        return sequence;
    }
    
}

