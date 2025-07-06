public class Solution {
    public int RemoveElement(int[] nums, int val) {
         int res = 0;
 int replacer = val + 1;

 for(int i = 0; i < nums.Length; i++)
 {
     if (nums[i] != val)
     {
         nums[res] = nums[i];
         res++;
     }
     else
     {
         nums[i] = replacer;
     }
 }

 return res;
    }
}