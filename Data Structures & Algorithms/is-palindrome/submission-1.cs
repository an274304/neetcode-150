public class Solution {
    public bool IsPalindrome(string s) {
        // Initialize two pointers at the beginning and end of the string
        int start = 0;
        int end = s.Length - 1;
        
        // Traverse while left pointer is less than right pointer
        // (no need to check middle character in odd-length strings)
        while (start < end) {
           
            // Move 'start' forward until it points to an alphanumeric character
            // This skips spaces, punctuation, etc.
            while (start < end && !char.IsLetterOrDigit(s[start])) {
                start++;
            }

            // Move 'end' backward until it points to an alphanumeric character
            while (start < end && !char.IsLetterOrDigit(s[end])) {
                end--;
            }

            // Compare characters in a case-insensitive manner
            // If mismatch found, it's not a palindrome
            if (char.ToLower(s[start]) != char.ToLower(s[end])) {
                return false;
            }

            // Move both pointers toward the center
            start++;
            end--;
        }

        // If all valid character pairs matched, it's a palindrome
        return true;
    }
}