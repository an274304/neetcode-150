public class Solution {
    public bool IsPalindrome(string s) {
        // Step 1: Remove all non-alphanumeric characters and convert to lowercase
        // This ensures we ignore spaces, punctuation, and case differences
        s = Regex.Replace(s, @"[^A-Za-z0-9]", "").ToLower();

        // Step 2: Initialize two pointers
        // 'start' begins from the left, 'end' from the right
        int start = 0;
        int end = s.Length - 1;

        // Step 3: Compare characters while moving inward
        while (start <= end) {
            // If mismatch found, it's not a palindrome
            if (s[start] != s[end]) return false;

            // Move both pointers toward the center
            start++;
            end--;
        }

        // Step 4: If all characters matched, it's a palindrome
        return true;
    }
}