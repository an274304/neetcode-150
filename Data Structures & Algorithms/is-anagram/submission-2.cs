public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        
        int[] frequency = new int[26];

        for(int i = 0; i < s.Length; i++){
            frequency[s[i] - 'a']++;
        }

        for(int i = 0; i < t.Length; i++){
            frequency[t[i] - 'a']--;
        }

        for(int i = 0; i < frequency.Length; i++){
            if(frequency[i] != 0) return false;
        }

        return true;
    }
}
