using System;
using maytinhdongian;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap so B: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap phep tinh (+, -, *, /): ");
        string op = Console.ReadLine();

        maytinh calc = new maytinh();
        calc.A = a;
        calc.B = b;
        calc.Operation = op;

        try
        {
            double kq = calc.Compute();
            Console.WriteLine("Ket qua: " + kq);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Loi: " + ex.Message);
        }

        Console.ReadKey();
    }
}
