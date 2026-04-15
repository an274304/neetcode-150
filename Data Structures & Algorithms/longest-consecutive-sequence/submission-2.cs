public class Solution {
    public int LongestConsecutive(int[] nums) {

        // Time Complexity: O(n)
        // - Each number is processed at most once
        // - HashSet lookup is O(1)

        // Space Complexity: O(n)
        // - HashSet stores all unique elements

        int longest = 0;

        // Store elements in HashSet for fast lookup
        HashSet<int> set = new HashSet<int>(nums);

        foreach(int num in set){

            // Only start counting if it's the beginning of a sequence
            // (i.e., no previous number exists)
            if(!set.Contains(num - 1)){

                int length = 1;

                // Count consecutive numbers
                while(set.Contains(num + length)){
                    length++;
                }

                // Update longest sequence found
                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }
}