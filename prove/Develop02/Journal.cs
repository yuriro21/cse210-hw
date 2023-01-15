using System;
using System.IO;
using System.Text;

public class Journal
{
    string filePath = "C:\\Users\\ediss\\OneDrive\\Documentos\\Pathway\\cse210-hw\\cse210-hw\\prove\\Develop02\\journals\\journal.cvs";
    List<Entry> _listPrompts = new List<Entry>();

    public Journal()
    {
    }

    public void Save()
    {
        Console.WriteLine("Enter a file name: ");
        string _save = Console.ReadLine();
        StreamReader streamReader = new StreamReader(filePath);
        while (!streamReader.EndOfStream)
        {
            var line = streamReader.ReadLine();
            var values = line.Split(",");
            Console.WriteLine("{0} - {1}", values);
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(string.Format("{0} - {1}", values));
            File.AppendAllText($@"C:\\Users\\ediss\\OneDrive\\Documentos\\Pathway\\cse210-hw\\cse210-hw\\prove\\Develop02\\journals\\{_save}.cvs", builder.ToString());
        }
        streamReader.Close();
    }

    public void Load()
    {
        Console.WriteLine("Enter the file name: ");
        string _load = Console.ReadLine();
        StreamReader streamReader = new StreamReader($@"C:\\Users\\ediss\\OneDrive\\Documentos\\Pathway\\cse210-hw\\cse210-hw\\prove\\Develop02\\journals\\{_load}.cvs");
        while (!streamReader.EndOfStream)
        {
            var line = streamReader.ReadLine();
            var values = line.Split(",");
            Console.WriteLine("{0}", values);
        }
        streamReader.Close();
    }
}