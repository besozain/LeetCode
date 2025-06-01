public class Solution {
    public string IntToRoman(int num) {
    int[] values = {1000, 500, 100, 50, 10, 5, 1 };
 string[] symbols = { "M", "D", "C", "L", "X", "V", "I" };
 int x = 0;
 int count = 0;
 StringBuilder result = new StringBuilder();
 while (x < values.Length - 1 && num < values[x]) { x++; }


 while (num >= values[x] && num > 0)
 {
     if (x % 2 == 0)
     {
         count++;
     }
     else
     {
         count = 0;
     }
     result.Append(symbols[x]);
         num -= values[x];
     if (count > 3)
     {
         result.Remove(result.Length - 3, 3).Append(symbols[x-1]);
         count = 0;
     }
     while (num < values[x] && x < values.Length-1 && num >0)
      {
             x++;
         count = 0;
     }
     if (result.ToString().Contains("VIV"))
     {
         result.Remove(result.Length - 3, 3).Append("IX");
     }
     else if (result.ToString().Contains("LXL"))
     {
         result.Remove(result.Length - 3, 3).Append("XC");
     }
     else if (result.ToString().Contains("DCD"))
     {
         result.Remove(result.Length - 3, 3).Append("CM");
     }
 }
 

     return result.ToString();
    }
}