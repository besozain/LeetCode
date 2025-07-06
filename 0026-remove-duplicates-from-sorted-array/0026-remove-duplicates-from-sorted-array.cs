public class Solution {
    public int RemoveDuplicates(int[] nums)
{
    int res = 0;
    int replacer = int.MaxValue;
   for (int i = 1; i < nums.Length; i++)
    {
        if (isduplicated(nums, nums[i]))
        {
            nums[i] = replacer;
            replacer--;
        }

    }

    Array.Sort(nums);
    for (int i = 0; i < nums.Length; i++)
    {
        Console.WriteLine(nums[i]);
        if (nums[i] <= replacer)
        {
            res++;
        }

    }
    return res;

}

public bool isduplicated(int[] nums, int num)
{
    int check = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == num)
        {
            check++;
            if (check > 1)
            {
                return true;
            }
        }
    }
    return false;
}
}