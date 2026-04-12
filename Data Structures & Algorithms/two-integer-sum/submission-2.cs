public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        // Dictionary to store number → its index
        // Key   = number from array
        // Value = index of that number
        Dictionary<int, int> map = new Dictionary<int, int>();

        // Traverse the array
        for (int i = 0; i < nums.Length; i++) {

            // Calculate the complement (number needed to reach target)
            int difference = target - nums[i];

            // Check if the complement already exists in dictionary
            // If yes, we found the two numbers
            if (map.ContainsKey(difference)) {

                // Return indices of complement and current number
                return new int[] { map[difference], i };
            }

            // Store current number and its index in dictionary
            // This will help future iterations find their complement
            map[nums[i]] = i;
        }

        // If no solution is found, return empty array
        // (Problem usually guarantees one solution, so this is fallback)
        return new int[0];
    }
}