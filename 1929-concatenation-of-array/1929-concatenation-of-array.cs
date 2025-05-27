public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int roundStart = 0;
        int round = 2;
        int start = 0;
        bool flag = true;
        int[] result = new int[nums.Length * 2];
        for(int i = 0 ; i < nums.Length; i++) {
            if(flag == true) {
            result[start] = nums[i];
            start++;
            if(i ==  nums.Length-1 ) {
                roundStart++;
                i = -1;
                if(roundStart == round){
                    flag = false;
                }
            }
            }
        }
        return result;
    }
}