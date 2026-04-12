public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        // Dictionary to group anagrams
        // Key   -> Encoded character frequency (e.g., "1#0#0#...#2")
        // Value -> List of words having the same frequency pattern
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        // Traverse each word in input
        foreach (string str in strs) {

            // Create a frequency array for 26 lowercase English letters
            // Index 0 -> 'a', Index 1 -> 'b', ..., Index 25 -> 'z'
            int[] freq = new int[26];

            // Count frequency of each character in the string
            foreach (char c in str) {
                freq[c - 'a']++;
            }

            // Convert frequency array into a unique string key
            // "#" is used as a separator to avoid ambiguity
            // Example: [1,0,2] → "1#0#2"
            string key = string.Join("#", freq);

            // If this key (anagram group) doesn't exist, create a new list
            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }

            // Add current word to its corresponding anagram group
            map[key].Add(str);
        }

        // Return all grouped anagrams as a list of lists
        return map.Values.ToList();
    }
}