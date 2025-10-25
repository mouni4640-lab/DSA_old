namespace TwoSum_LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array with spaces:");
            string input = Console.ReadLine();

            // Convert the input string into an array of integers
            int[] nums = input.Split(' ') // Split by spaces
                                 .Select(int.Parse) // Convert each part to an integer
                                 .ToArray();
            Console.WriteLine("Enter Target:");
            int.TryParse(Console.ReadLine(),out var target);

            var indices = TwoSum(nums, target);
            Console.WriteLine("Indices are: ");
            for (int i = 0; i < indices.Length; i++)
            {
                Console.WriteLine(indices[i]);
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var indices = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                var remainder = target - nums[i];
                for (int j = 1; j < nums.Length; j++)
                {
                    if (remainder == nums[j])
                    {
                        indices[0] = i;
                        indices[1] = j;
                        break;
                    }
                    //break;
                }
            }
            return indices;
        }

        /*         
        Example 1:
        Input: nums = [2,7,11,15], target = 9
        Output: [0,1]
        Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

        Example 2:
        Input: nums = [3,2,4], target = 6
        Output: [1,2]
        
        Example 3:
        Input: nums = [3,3], target = 6
        Output: [0,1]*/
    }
}
