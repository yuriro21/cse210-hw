using System;
using System.IO;
using System.Text;

public class Entry
{
    string filePath = "C:\\Users\\ediss\\OneDrive\\Documentos\\Pathway\\cse210-hw\\cse210-hw\\prove\\Develop02\\journals\\journal.cvs";
    
    public Entry()
    {
    }

    public void Write(string _text)
    {
        StringBuilder _builder = new StringBuilder();
        DateTime date = DateTime.Now;

        string _newDate = date.ToShortDateString();
        string _userText = _text;
        _builder.AppendLine(string.Format("{0},{1}", _newDate, _userText));

        File.WriteAllText(filePath, _builder.ToString());
    }

    public void Read()
    {
        StreamReader streamReader = new StreamReader(filePath);

        while (!streamReader.EndOfStream)
        {
            var line = streamReader.ReadLine();
            var values = line.Split(",");
            Console.WriteLine("{0} - {1}", values);
        }
        streamReader.Close();
    }
}