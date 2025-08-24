public class Solution {
    public int SingleNumber(int[] nums) {
        if (nums.Length == 1)
        {
            return nums.First();
        }
        List<int> ints = nums.ToList();
        int test = ints[0];
        int count = 0;
        for(int i = 0; i < ints.Count; i++)
        {
            if (test == ints[i])
            {
                count++;
                if (count == 2)
                {
                    ints.RemoveAll(s => s == test);
                    count = 0;
                    i = -1;
                } 
                if(ints.Count == 1)
                {
                    return ints[0];
                }
                test = ints[0];
            }

        }
        return test;
    }
}