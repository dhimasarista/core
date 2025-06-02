class Program
{
    static void Main(string[] args)
    {
        string key = "C#";
        int tableSize = 7;
        int hash = 0;
        foreach (char c in key)
        {
            hash = (hash * 31 + c) % tableSize;  // Menghasilkan hash sederhana
        }
        
        Console.WriteLine($"Hash untuk kunci {key} adalah: {hash}");
    }
}