
namespace CodeChallenge
{
    public class CodeChallenge01Aug16
    {
        public int FindIndex(int[] numbers)
        {
            var index = -1;
            var leftSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                var rightSum = 0;
                if(i != 0) leftSum += numbers[i-1];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
                if (leftSum == rightSum)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
