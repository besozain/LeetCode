public class Solution {
    public int Divide(int dividend, int divisor) {
       
    
    long a = (long)dividend;
    long b = (long)divisor;
    int res = 0;
    bool flag = false;
    if (a == int.MinValue && b == -1)
    {
        return int.MaxValue;
    }
    if (b <= 0 && a <= 0)
    {
        b = Math.Abs(b);
        a = Math.Abs(a);
    }
    if (b <= 0 && a >= 0 || b >= 0 && a <= 0)
    {
        flag = true;
        b = Math.Abs(b);
        a = Math.Abs(a );
    }
    while (a - b >= 0)
    {
        int x = 0;
        while (a - (b << 1 << x) >= 0)
        {
            x++;
            
        }
        res += 1 << x;
        a -= b << x;
    }
    if (flag)
    {
        res = -res;
    }
    return res;

    }
}