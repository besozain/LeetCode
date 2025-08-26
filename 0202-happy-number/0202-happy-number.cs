public class Solution {
    public bool IsHappy(int n) {
    if(n == 1)
        {
            return true;
        }
        int num = n;
        HashSet<int> uniques = new HashSet<int>();
        List<int> values = new List<int>();
        do
        {
            uniques.Add(num);
            values.Add(num);
            if(uniques.Count != values.Count)
            {
                return false;
            }
            string strNum = num.ToString();
            double res = 0;
            for(int i = 0; i < strNum.Length; i++)
            {
                res += Math.Pow(Convert.ToDouble($"{strNum[i]}"), 2);
            }
            num = (int)res;

        } while (num != 1);
        return true;
    }
}