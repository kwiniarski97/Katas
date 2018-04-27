namespace Katas
{
    public class IQ
    {
        public static int Test(string numbers)
        {
            var numbersOfEven = 0;
            var posOfEven = -1;
            var posOfOdd = -1;
            var array = numbers.Split(' ');
            for (var i = 0; i < array.Length; i++)
            {
                var num = int.Parse(array[i]);
                if (num % 2 == 0)
                {
                    numbersOfEven++;
                    posOfEven = i + 1;
                }
                else
                {
                    posOfOdd = i + 1;
                }
            }

            return numbersOfEven > 1 ? posOfOdd : posOfEven;
        }
    }
}