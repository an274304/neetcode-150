public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        // Step 1: Create a dictionary to store frequency of each number
        // Key   -> number
        // Value -> frequency count
        Dictionary<int, int> map = new Dictionary<int, int>();

        // Step 2: Traverse the array and count frequencies
        foreach (int num in nums) {
            if (map.ContainsKey(num)) {
                map[num]++;      // increment count if already exists
            } else {
                map[num] = 1;    // initialize count
            }
        }

        // Step 3: Sort the dictionary by frequency in descending order
        // Then take top 'k' elements and extract only the keys (numbers)
        var sorted = map
                        .OrderByDescending(x => x.Value) // sort by frequency
                        .Take(k)                         // take top k frequent
                        .Select(x => x.Key)              // extract numbers
                        .ToArray();                      // convert to array

        // Step 4: Return result
        return sorted;
    }
}