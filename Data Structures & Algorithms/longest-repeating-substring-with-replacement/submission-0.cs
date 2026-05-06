public class Solution {
    public int CharacterReplacement(string s, int k) {
        // Dictionary to store frequency of characters in current window
        Dictionary<char,int> count = new Dictionary<char,int>();

        int res = 0;     // Stores the maximum valid window length
        int l = 0;       // Left pointer of sliding window
        int maxf = 0;    // Stores the count of the most frequent character in window

        // Expand the window using right pointer
        for(int r = 0; r < s.Length; r++){

            // Update frequency of current character
            if(count.ContainsKey(s[r])){
                count[s[r]]++;
            }
            else{
                count[s[r]] = 1;
            }

            // Track the highest frequency character in the current window
            maxf = Math.Max(maxf, count[s[r]]);

            // If replacements needed > k, shrink window from left
            // Window size = (r - l + 1)
            // Characters to replace = window size - max frequency character
            while((r - l + 1) - maxf > k){
                count[s[l]]--;   // Reduce count of left character
                l++;             // Move left pointer forward
            }

            // Update result with the maximum valid window size
            res = Math.Max(res, (r - l + 1));
        }

        return res;
    }
}