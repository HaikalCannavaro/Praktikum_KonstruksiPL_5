
using static System.Runtime.InteropServices.JavaScript.JSType;

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;
    public  SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T x)
    {
        storedData.Add(x);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++) 
        {
            Console.WriteLine("Data " + (i + 1) + " berisi " + storedData[i] + " yang disimpan pada waktu " + inputDates[i]);
        }

    }
}

public class program
{
    public static void Main()
    {
        SimpleDataBase<int> x = new SimpleDataBase<int> ();
        x.AddNewData(10);
        x.AddNewData(30);
        x.AddNewData(22);
        x.PrintAllData();
        
    }
}
