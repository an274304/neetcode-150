public class Solution {

    // Compare both frequency arrays
    // Returns true if all character counts match
    public bool CountMatches(int[] s1Count, int[] windowCount) {

        for (int i = 0; i < 26; i++) {

            // If any character frequency differs
            // current window is not a permutation
            if (s1Count[i] != windowCount[i]) {
                return false;
            }
        }

        return true;
    }

    public bool CheckInclusion(string s1, string s2) {

        // If s1 is larger than s2
        // permutation cannot exist
        if (s1.Length > s2.Length) {
            return false;
        }

        // Frequency arrays for:
        // s1 characters
        // current sliding window characters
        int[] s1Count = new int[26];
        int[] windowCount = new int[26];

        // Build frequency for:
        // 1. s1
        // 2. first window in s2
        for (int i = 0; i < s1.Length; i++) {

            s1Count[s1[i] - 'a']++;

            windowCount[s2[i] - 'a']++;
        }

        // Check first window
        if (CountMatches(s1Count, windowCount)) {
            return true;
        }

        // Sliding window
        for (int i = s1.Length; i < s2.Length; i++) {

            // Add new character to window
            windowCount[s2[i] - 'a']++;

            // Remove leftmost character from window
            windowCount[s2[i - s1.Length] - 'a']--;

            // Compare frequencies
            if (CountMatches(s1Count, windowCount)) {
                return true;
            }
        }

        // No permutation found
        return false;
    }
}