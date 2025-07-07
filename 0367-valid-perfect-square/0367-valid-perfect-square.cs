public class Solution {
    public bool IsPerfectSquare(int num) {
         int numtest = num;
 int check = 0;
 int test =(int)Math.Ceiling( (numtest / 2.0) * (numtest / 2.0));

 while ( test*test > num)
 {
     numtest = numtest / 2;
     test = (int)Math.Ceiling((numtest / 2.0) * (numtest / 2.0));
 }
 check = test;

 if (test*test == num)
 {
     return true;
 }else if (test*test < num)
 {
     while (test * test <= num)
     {
         test++;
         if (test * test == num)
         {
             return true;
         }
         if ( test == check*check)
         {
             return false;
         }
     }
 }
 return false;
        
    }
}