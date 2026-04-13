public class Solution {

    // Encodes a list of strings into a single string
    public string Encode(IList<string> strs) {
        string result = "";

        // For each string, store its length + delimiter '#' + actual string
        // Example: "cat" -> "3#cat"
        foreach(string str in strs){
            result += str.Length + "#" + str;
        }

        // Final encoded string: "3#cat3#dog"
        return result;
    }

    // Decodes a single string back into list of strings
    public List<string> Decode(string s) {
        List<string> ls = new List<string>();
        string str = s;

        // Process until entire string is consumed
        while(str.Length > 0){

            // Step 1: Find position of delimiter '#'
            int indexOfHash = str.IndexOf("#");

            // Step 2: Extract length of next word (from start to '#')
            int lengthOfString = int.Parse(str.Substring(0, indexOfHash));

            // Step 3: Extract actual word using known length
            // Start = indexOfHash + 1 (after '#')
            // Length = lengthOfString
            string word = str.Substring(indexOfHash + 1, lengthOfString);

            // Step 4: Add extracted word to result list
            ls.Add(word);

            // Step 5: Move forward in string
            // Skip: length part + '#' + actual word
            str = str.Substring(indexOfHash + 1 + lengthOfString);
        }

        return ls;
   }
}