public class Solution {
    public int TrailingZeroes(int n) {
        double i = 1;
        int dev = (int) Math.Pow(5, i);
        int res = 0;
        while(n >= dev)
        {
            res += n / dev;
            i++;
            dev = (int)Math.Pow(5, i);

        }
        return res;
    }
}