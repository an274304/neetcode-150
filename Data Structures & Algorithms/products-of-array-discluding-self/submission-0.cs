public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;

        // prefix[i] will store product of all elements before index i
        int[] prefix = new int[n];

        // suffix[i] will store product of all elements after index i
        int[] suffix = new int[n];

        // result array to store final answer
        int[] result = new int[n];

        // No elements before first index → set to 1 (neutral element for multiplication)
        prefix[0] = 1;

        // No elements after last index → set to 1
        suffix[n - 1] = 1;

        // Build prefix array
        // prefix[i] = product of nums[0] to nums[i-1]
        for(int i = 1; i < n; i++){
            prefix[i] = nums[i - 1] * prefix[i - 1];
        }

        // Build suffix array
        // suffix[i] = product of nums[i+1] to nums[n-1]
        for(int i = n - 2; i >= 0; i--){
            suffix[i] = nums[i + 1] * suffix[i + 1];
        }

        // Final result:
        // product except self = prefix[i] * suffix[i]
        for(int i = 0; i < n; i++){
            result[i] = prefix[i] * suffix[i];
        }

        return result;
    }
}