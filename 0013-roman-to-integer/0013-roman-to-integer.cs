public class Solution {
    public int RomanToInt(string s) {
           Dictionary<char, int> romanNumerals = new Dictionary<char, int>
  {
      { 'I', 1 },
      { 'V', 5 },
      { 'X', 10 },
      { 'L', 50 },
      { 'C', 100 },
      { 'D', 500 },
      { 'M', 1000 }
  };
  char[] romanChars = { 'I','X','C' };
  char[][] romanChars2 = {['V','X'], ['L','C'] , ['M','D']  };


  int result = 0;
  for (int i = 0; i < s.Length; i++)
  {
      if (romanNumerals.ContainsKey(s[i]))
      {
          result += romanNumerals[s[i]];

          
      }
      if (romanChars.Contains(s[i]) && i <( s.Length-1))
      {
          if (romanChars2[Array.IndexOf(s.ToArray(), s[i])].Contains(s[i+1])) 
               result -= 2 * romanNumerals[s[i]];
      }

  }
  return result;

    }
}