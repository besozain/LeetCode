public class Solution {
    public IList<string> FizzBuzz(int n) {
        int num = 1;
        List<string> str = Enumerable.Repeat("", n).ToList();
    
        num = 1;
        while (n >= 3 * num)
        {          
            str[(3 * num) - 1] = "Fizz";
            num++;
        }
        num = 1;
        while (n >= 5 * num)
        {
            str[(5 * num) - 1] = "Buzz";
            num++;
        }
        num = 1;
        while (n >= 3 * 5 * num)
        {
            str[(3 * 5 * num) - 1] = "FizzBuzz";
            num++;
        }


        for (int i = 0; i < n; i++) {
            if (str[i] == "")
            {
                str[i] = $"{i + 1}";
            }
        }
        return str;
    }
}