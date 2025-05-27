public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int round = 2;
        int start = 0;
        int[] result = new int[nums.Length * 2];
        for(int i = 0 ; i < round; i++) {
            for(int j = 0 ; j < nums.Length; j++) {
                result[start] = nums[j];
                start++;
            }
        }
        return result;
    }
}