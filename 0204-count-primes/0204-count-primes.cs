public class Solution {

public int CountPrimes(int n)
{
    bool[] isPrime = new bool[n];
    if (n < 2)
    {
        return 0;
    }
    for (int i = 2; i < n; i++)
    {
        isPrime[i] = true;
    }
    for (int i = 2; i * i < n; i++)
    {
        if (IsPrime(i))
        {
            for (int j = i * i; j < n; j += i)
            {
                isPrime[j] = false;
            }
        }
    }
    int count = 0;
    for (int i = 2; i < n; i++)
    {
        if (isPrime[i])
        {
            count++;
        }
    }
    return count;


}
public bool IsPrime(int n)
{
    if (n < 2)
    {
        return false;
    }
    if (n == 2)
    {
        return true;
    }
    for (int i = 2; i * i <= n; i += 2)
    {
        if (n % i == 0)
        {
            return false;
        }
    }

    return true;
}
}