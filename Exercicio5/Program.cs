using System;
class Program{
    static void Main(){
        Console.WriteLine("Digite a string: ");
        var stringNormal = Console.ReadLine();
        Console.WriteLine("Sua String invertida: "+InverteString(stringNormal));
    }
    public static string InverteString(string str){
        char[] charArray = str.ToCharArray();
        int i = 0, j = charArray.Length - 1;

        while (i < j)
        {
            char temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;

            i++;
            j--;
        }
        return new string(charArray);
    }

}
