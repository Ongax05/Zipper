using System.IO.Compression;

internal class Program
{
    private static void Main(string[] args)
    {
        string EntryPath = "C:/Example/EntryPath";
        string OutputPath = "C:/Example/OutputPath";
        if (!Directory.Exists(OutputPath)){
            Directory.CreateDirectory(OutputPath);
        }
        var directiories = Directory.EnumerateDirectories(EntryPath);
        
        Console.Clear();
        Console.WriteLine("Zipping Initiation\n\n");
        foreach (var directiory in directiories){
            string zipName = $"{OutputPath}/{directiory.Remove(0, EntryPath.Length + 1)}.zip";
            Console.WriteLine($"Zipping: {zipName}");
            ZipFile.CreateFromDirectory(directiory,zipName);
            Console.WriteLine("Zip done\n");
        }
        Console.Clear();
        Console.WriteLine("Zipping done, thanks for using");
        //Made by Ongax
    }
}