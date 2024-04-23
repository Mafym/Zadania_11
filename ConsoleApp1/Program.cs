using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Tablice Tablice = new Tablice();
        Tablice.Powitanie();
        int [] tab = Tablice.Stworz_Tablice();

        Console.Clear();
        Tablice.Wyswietl_Tablice(tab);
        Tablice.SortujBabelkowo(tab);s
        Tablice.Wyswietl_Tablice(tab);
    }
}