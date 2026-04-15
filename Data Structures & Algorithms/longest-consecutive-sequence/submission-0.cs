public class Solution {
    public int LongestConsecutive(int[] nums) {
        int n = nums.Length;
        Array.Sort(nums);
        int streak = 0;

        for (int i = 0; i < n; i++) {
            int curr = nums[i];
            int subStreak = 1;

            for (int j = 0; j < n; j++) {
                if(nums[i] == nums[j]) continue;

                if((curr + 1) == nums[j]){
                    curr = curr + 1;
                    subStreak++;
                }
            }

            streak = Math.Max(streak,subStreak);
        }

        return streak;
    }
}
