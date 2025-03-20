public class PemrosesData 
{
    public void DapatkanNilaiTerbesar<T>(T a, T  b, T c)
    {
        dynamic max = 0;
        dynamic x = a;
        dynamic y = b;
        dynamic z = c;

        if (x > y && x > z)
        {
            max = x;
        }
        else if (y > x && y > z)
        {
            max = y;
        }
        else if (z > x && z > y)
        {
            max = z;
        }
        else 
        {
            Console.WriteLine("Inputan tidak valid");
        }
        Console.WriteLine("Nilai terbesar = " + max);
    }
}

class program
{
    static void Main() 
    {
        PemrosesData pemroses = new PemrosesData();
        pemroses.DapatkanNilaiTerbesar(10, 30, 22);
    }
}
