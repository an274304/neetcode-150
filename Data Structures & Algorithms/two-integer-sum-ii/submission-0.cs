public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        // 🔹 Two Pointer Approach
        // Since array is sorted, we can use start (left) and end (right) pointers
        int start = 0;
        int end = numbers.Length - 1;

        while(start < end){

            int currentSum = numbers[start] + numbers[end];

            // ✅ Found the pair
            if(target == currentSum){

                // ❌ MISTAKE (important for interviews):
                // Problem asks for 1-indexed positions,
                // but array is 0-indexed in C#
                // 👉 So we must return start+1 and end+1

                return new int[]{start + 1, end + 1};
            }

            // 🔹 If sum is too large → move right pointer left
            if(target < currentSum){
                end--;
            }
            // 🔹 If sum is too small → move left pointer right
            else{
                start++;
            }
        }

        // Problem guarantees exactly one solution,
        // so this line ideally never executes
        return new int[]{-1,-1};
    }
}