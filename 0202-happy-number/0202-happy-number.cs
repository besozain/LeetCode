public class Solution {
    public bool IsHappy(int n) {
        if(n == 1)
        {
            return true;
        }
        int num = n;
        List<int> lst = new List<int>();
        do
        {
            lst.Add(num);
            string strNum = num.ToString();
            double res = 0;
            for(int i = 0; i < strNum.Length; i++)
            {
                res += Math.Pow(Convert.ToDouble($"{strNum[i]}"), 2);
            }
            num = (int)res;
            if (lst.Contains(num))
            {
                return false;
            }
        } while (num != 1);
        return true;
    }
}