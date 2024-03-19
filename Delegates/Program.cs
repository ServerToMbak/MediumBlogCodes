using System.Globalization;

public  class Program
{
    public delegate int MyDelegate(int x,int y);

    static int AddMethod(int x, int y)
    {
        return x + y;
    }

    static int SubtractMethod(int x, int y)
    {
        return x - y;
    }

    private static void Main(string[] args)
    {
      AnotherExample obj = new AnotherExample();
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12 };

        var result = obj.CountLessThan(nums, n => n < 3 );

        foreach (var res in result)
        {
            Console.WriteLine(res);
        }
    }
}