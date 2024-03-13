/*
 Write a function findNeedle() that takes an array full of junk but containing one "needle"

After your function finds the needle it should return a message (as a string) that says:

"found the needle at position " plus the index it found the needle, so:

Example(Input --> Output)

    ["hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk"] --> "found the needle at position 5"
Note: In COBOL, it should return "found the needle at position 6"
*/
class Program
{
    static void Main(string[] args)
    {
        object[] arr = { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };
        Console.WriteLine(FindNeedle(arr));
        
    }
    public static string FindNeedle(object[] haystack)
    {
        int position = 0;

        foreach (object item in haystack)
        {
            if(item != null && item.ToString() == "needle") {return $"found the needle at position {position}";}
            position++;
        }
        return "error";
    }
}

// return "found the needle at position " + Array.IndexOf(haystack,"needle");

// return $"found the needle at position {Array.IndexOf(haystack, "needle")}";

/*
int i=0;
    while(haystack[i]!="needle"){
      i++;
    }
    return "found the needle at position " + i;
*/