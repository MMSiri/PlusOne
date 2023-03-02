internal class Program
{
    private static void Main(string[] args)
    {
        var results = Solution.PlusOne(new int[] {9,9,9 });

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
}

public class Solution
{
    public static int[] PlusOne(int[] digits)
    {
        if (digits[^1] < 9)
        {
            digits[^1] += 1;
            return digits;
        }

        else
        {
            List<int> listOfDigits = digits.ToList();

            for (int i = listOfDigits.Count -1; i > -1; i--)
            {
                if (i != 0 && listOfDigits[i] == 9)
                {
                    listOfDigits[i] = 0;
                    continue;
                }
                else if (listOfDigits[i] == 9)
                {
                    listOfDigits[i] = 0;
                    listOfDigits.Insert(0, 1);
                    return listOfDigits.ToArray<int>();
                }
                else
                {
                    listOfDigits[i] += 1;
                    return listOfDigits.ToArray<int>();
                }
            }
            return listOfDigits.ToArray<int>();

        }
    }
}