public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
    List<int> result = new List<int>((nums1.Length + nums2.Length));
    for (int i = 0; i < nums1.Length; i++)
    {
        result.Add(nums1[i]);
    }
    for (int i = 0; i < nums2.Length; i++)
    {
        result.Add(nums2[i]);
    }
    result.Sort();
    if(result.Count % 2 != 0)
    {
        return result[result.Count / 2];
    }
    else
    {
        double num1 = result[result.Count / 2];
        double num2 = result[(result.Count / 2) - 1];
        return (num1 + num2) / 2;

    }
    }
}