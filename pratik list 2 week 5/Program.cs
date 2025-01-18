class Program
{
    static void Main()
    {
        List<string> kahveListesi = new List<string>();

        Console.WriteLine("Lütfen 5 adet kahve ismi giriniz:");


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"kahve {i + 1}: ");
            string kahve = Console.ReadLine();
            kahveListesi.Add(kahve);

        }
        Console.WriteLine("\ngirilen kahve isimeleri:");
        foreach (string kahve in kahveListesi)
        {
            Console.WriteLine(kahve);
        }
    }
}