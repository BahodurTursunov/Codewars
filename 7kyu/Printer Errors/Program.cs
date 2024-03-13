namespace Printer_Errors;

class Program
{
    static void Main(string[] args)
    {
        string letters = PrinterError("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz");
        Console.WriteLine(letters);
    }
    public static string PrinterError(string s)
    {
        int errorCount = 0;

        foreach (var c in s)
        {
            if (c < 'a' || c > 'm') errorCount++;
        }
        return errorCount + "/" + s.Length;
    }
}

// return s.Where(c => c > 'm').Count() + "/" + s.Length;

/*
public static string PrinterError(String s) 
{
    int num = s.Select(c => IsValid(c)).Sum();
    return String.Format("{0}/{1}", num, s.Length);            
}

public static int IsValid(char c)
{
   if ('a' <= c && 'm' >= c)
      return 0;
   else
      return 1;
}
*/

/*
 private const string pattern = @"[^a-m]";
    public static string PrinterError(String s) 
    {
        return $"{Regex.Matches(s, pattern).Count}/{s.Length}";
    }
*/

/*
var errorsCount = message.Count(s => s < 'a' || s > 'm');
        var messageLength = message.Length.ToString();
        var errorsRate = String.Format("{0}/{1}", errorsCount, messageLength);
        
        return errorsRate;
*/