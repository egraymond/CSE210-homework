using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions f_1 = new Fractions();
        Fractions f_2 = new Fractions(6);
        Fractions f_3 = new Fractions(6/2);
        Fractions f_4 = new Fractions(2/5);

        f_1.GetFractionString();
        f_1.GetDecimalValue();

        f_2.GetFractionString();
        f_2.GetDecimalValue();

        f_3.GetFractionString();
        f_3.GetDecimalValue();

        f_4.GetFractionString();
        f_4.GetDecimalValue();
    }
}

