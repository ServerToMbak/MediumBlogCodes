public class AnotherExample
{
  

    public delegate bool CheckValue(int number);
    public IEnumerable<int> CountLessThan(IEnumerable<int> nums, CheckValue value)
    {
        foreach (int number in nums)
        {
            if (value(number))
            {
                yield return number;
            }
        }

    }

}