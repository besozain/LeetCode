public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
int avarage = nums.Length / 2;
int count = 0;
int result = 0;
if(nums.Length == 1) {
    return nums[0] ;
}

for (int i = 0; i < nums.Length; i++)
{
    if(i < nums.Length -1 && nums[i] == nums[i + 1] )
    {
        count++;
        if (count >= avarage)
        {
            result = nums[i];
        }
    }
    else
    {
        count = 0;
    }

}
return result;
    }
}