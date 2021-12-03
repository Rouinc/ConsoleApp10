using System;

public class Program
{
    public static void Main()
    {
        int angka;

        Console.WriteLine("Input angka");
        angka = Convert.ToInt32(Console.ReadLine());
        if (angka == 0 || angka == 1)
        {
            Console.WriteLine(angka + " bukan bilangan prima");
            Console.ReadLine();
        }
        else
        {
            {
                if (angka % 2 == 0)
                {
                    Console.WriteLine(angka + "  bukan bilangan prima");
                }

            }
            {
                if (angka % 2 != 0)
                {
                    Console.WriteLine(angka + "  adalah bilangan prima");
                }
            }
        }
    }
}