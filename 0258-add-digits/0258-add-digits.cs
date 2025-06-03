public class Solution {
    public int AddDigits(int num) {
         string y = num.ToString();
 int sum = 0;
 while (y.Length > 1)
 {
     sum = 0;
     for (int i = 0; i < y.Length; i++)
     {
         sum += int.Parse((y[i].ToString()));
     }
     y = sum.ToString();
 }
 return int.Parse(y);
    }
}