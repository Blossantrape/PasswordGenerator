namespace FileGenerator;

public static class FileWriter
{
    public static void WritePasswordsToFile(string filePath, IEnumerable<string> passwords)
    {
        File.WriteAllLines(filePath, passwords);
    }
}