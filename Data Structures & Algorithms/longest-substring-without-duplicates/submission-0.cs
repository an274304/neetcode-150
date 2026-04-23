public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        // HashSet to store unique characters in current window
        HashSet<char> set = new HashSet<char>();

        int left = 0;       // Left pointer of sliding window
        int maxLength = 0;  // Stores result

        // Right pointer expands the window
        for (int right = 0; right < s.Length; right++) 
        {
            // If duplicate found, shrink window from left
            while (set.Contains(s[right])) 
            {
                set.Remove(s[left]); // remove leftmost char
                left++;              // move left pointer forward
            }

            // Add current character to the window
            set.Add(s[right]);

            // Update maximum length of valid window
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}