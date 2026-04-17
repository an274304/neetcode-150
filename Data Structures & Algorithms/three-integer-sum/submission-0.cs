public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {

        // 🔹 Step 1: Sort the array
        // Required for:
        // - Two pointer approach
        // - Handling duplicates
        // - Optimization (nums[i] > 0)
        Array.Sort(nums);

        List<List<int>> res = new List<List<int>>();

        // 🔹 Step 2: Fix one element (nums[i])
        for(int i = 0; i < nums.Length; i++){

            // 🔹 Optimization:
            // If current number > 0, all numbers after it are also > 0
            // So sum can never be 0 → break early
            if(nums[i] > 0) break;

            // 🔹 Skip duplicate values for 'i'
            // Avoid duplicate triplets
            if(i > 0 && nums[i] == nums[i - 1]) continue;

            // 🔹 Step 3: Two pointers
            int start = i + 1;              // left pointer
            int end = nums.Length - 1;      // right pointer

            while(start < end){

                int totalSum = nums[i] + nums[start] + nums[end];

                // ✅ Case 1: Found valid triplet
                if(totalSum == 0){

                    res.Add(new List<int>() { nums[i], nums[start], nums[end] });

                    // 🔹 Move both pointers
                    start++;
                    end--;

                    // 🔹 Skip duplicates for 'start' (left pointer)
                    while(start < end && nums[start] == nums[start - 1]){
                        start++;
                    }

                    // 🔹 Skip duplicates for 'end' (right pointer)
                    while(start < end && nums[end] == nums[end + 1]){
                        end--;
                    }
                }

                // 🔹 Case 2: Sum too small → increase it
                else if(totalSum < 0){
                    start++;
                }

                // 🔹 Case 3: Sum too large → decrease it
                else{
                    end--;
                }
            }
        }

        return res;
    }
}