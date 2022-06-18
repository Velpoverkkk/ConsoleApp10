using System;
class Program
{   //Задан массив из k сиволов.Определить количество инверсий в массиве.
    static void Main(string[] args)
    {
        String s;
        int k,n=0;
        System.Console.WriteLine("Razmer massiva");
        s = Console.ReadLine();
        k = System.Convert.ToInt32(s);
        int[] array = new int[k];
        System.Console.WriteLine("Vvod massiva: ");
        for (int i = 0; i < array.Length; i++)
        {
            s = Console.ReadLine();
            array[i] = System.Convert.ToInt32(s);
        }
        for(int i = 0; i < array.Length-1; i++)
        {
            if (array[i] > array[i + 1]) 
            {
                n++;
                System.Console.WriteLine("Inversia par : " + array[i] + "  " + array[i + 1]); 
            }
        }
        System.Console.WriteLine("kolvo invers: " + n);
        
    }    
}
