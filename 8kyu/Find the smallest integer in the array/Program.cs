/*
Given an array of integers your solution should find the smallest integer.

    For example:

Given [34, 15, 88, 2] your solution will return 2
Given [34, -345, -1, 100] your solution will return -345
You can assume, for the purpose of this kata, that the supplied array will not be empty.
*/

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 78, 56, 232, 12, 11, 43 };
        Console.WriteLine(FindSmallestInt(arr));
    }
    static int FindSmallestInt(int[] arr)
    {
        int tmp = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < tmp)
            {
                tmp = arr[i];
            }
        }
        return tmp;
    }
}


/*
  public class Kata 
{
    public static int FindSmallestInt(int[] args) => args.Min();
}
 */

/*
  public static int FindSmallestInt(int[] args) 
    {
      return Enumerable.Min(args);
    }
 */


/*
 public static int FindSmallestInt(int[] args) 
    {
      Array.Sort(args);
      
      return args[0];
    }
 */

//return (from e in args orderby e ascending select e).FirstOrDefault();