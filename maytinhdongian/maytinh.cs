using System;

namespace maytinhdongian
{
    public class maytinh
    {
        public double A { get; set; }
        public double B { get; set; }
        public string Operation { get; set; } // "+", "-", "*", "/"

        public double Compute()
        {
            switch (Operation)
            {
                case "+": return A + B;
                case "-": return A - B;
                case "*": return A * B;
                case "/": return B != 0 ? A / B : double.NaN;
                default: throw new Exception("Phép tính không hợp lệ");
            }
        }
    }
}
