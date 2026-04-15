public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        // Store all elements in a HashSet for O(1) lookup
        // This helps us check if a number exists quickly
        HashSet<int> set = new HashSet<int>(nums);

        int result = 0; // Stores the maximum length of consecutive sequence

        // Iterate through each number in the array
        foreach(int num in nums){

            int curr = num;     // Start of current sequence
            int streak = 0;     // Length of current consecutive sequence

            // Keep checking if the next consecutive number exists
            while(set.Contains(curr)){
                curr++;        // Move to next number
                streak++;      // Increase streak length
            }

            // Update the maximum streak found so far
            result = Math.Max(result, streak);
        }

        return result; // Return longest consecutive sequence length
    }
}