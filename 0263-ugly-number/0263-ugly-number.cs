public class Solution {
    public bool IsUgly(int n) {
         if (n <= 0) return false;
 else if (n == 1) return true;

 List<int> primes = new List<int> { 2, 3, 5 };
 if (primes.Contains(n)) return true;
 for (int i = 0; i < primes.Count; i++)
 {
     while (n % primes[i] == 0)
     {
         if (primes.Contains(n / primes[i]))
         {
             return true;
         }
         n /= primes[i];
     }
 }
 return false;
}}