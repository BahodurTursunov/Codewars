/* Your classmates asked you to copy some paperwork for them.
 * You know that there are 'n' classmates and the paperwork has 'm' pages.

Your task is to calculate how many blank pages do you need. If n < 0 or m < 0 return 0.

Example:
n= 5, m=5: 25
n=-5, m=5:  0
Waiting for translations and Feedback! Thanks! */

namespace Beginner_Series__1__School_Paperwork;

internal class Program
{
    private static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int result = Paperwork(a, b);
        Console.WriteLine(result);
    }

    static int Paperwork(int n, int m)
    {
        if (n <= 0 || m <= 0)
        {
            return 0;
        }

        return n * m;
    }
}
//  [TestFixture]
//public class PaperWork
//{
//    [Test]
//    public void Test()
//    {
//        Assert.AreEqual(25, Paper.Paperwork(5, 5));
//        Assert.AreEqual(0, Paper.Paperwork(5, -5));
//        Assert.AreEqual(0, Paper.Paperwork(-5, -5));
//        Assert.AreEqual(0, Paper.Paperwork(-5, 5));
//        Assert.AreEqual(0, Paper.Paperwork(5, 0));
//    }
//}