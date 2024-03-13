/*
Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including them
and return it. If the two numbers are equal return a or b.

Note: a and b are not ordered!

Examples (a, b) --> output (explanation)
(1, 0) --> 1 (1 + 0 = 1)
(1, 2) --> 3 (1 + 2 = 3)
(0, 1) --> 1 (0 + 1 = 1)
(1, 1) --> 1 (1 since both are same)
(-1, 0) --> -1 (-1 + 0 = -1)
(-1, 2) --> 2 (-1 + 0 + 1 + 2 = 2)
Your function should only return a number, not the explanation about how you get that number.
 */

class Program
{
    static void Main(string[] args)
    {
        int sum = GetSum(-1,3);
        
        Console.WriteLine(sum);
    }
    
    static int GetSum(int a, int b)
    {
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);
        // Если a и b равны, возвращаем любое из них
        if (min == max)
        {
            return a;
        }
        // Инициализируем переменную для хранения суммы
        int sum = 0;
        // Проходим по всем числам от min до max, включительно, и суммируем их
        for (int i = min; i <= max; i++)
        {
            sum += i;
        }
        // Возвращаем сумму
        return sum;
    }
}