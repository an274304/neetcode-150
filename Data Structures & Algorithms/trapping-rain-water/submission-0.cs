public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;

        // Edge case: no bars → no water
        if (n == 0) return 0;

        // Prefix arrays:
        // leftMax[i]  = max height from 0 → i
        // rightMax[i] = max height from i → n-1
        int[] leftMax = new int[n];
        int[] rightMax = new int[n];
        
        int water = 0;

        // Build leftMax array
        // At each index, store the highest bar seen so far from the left
        leftMax[0] = height[0];
        for(int i = 1; i < n; i++){
            leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
        }

        // Build rightMax array
        // At each index, store the highest bar seen so far from the right
        rightMax[n - 1] = height[n - 1];
        for(int i = n - 2; i >= 0; i--){
            rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
        }

        // Compute trapped water at each index
        // Water = min(left boundary, right boundary) - current height
        for(int i = 0; i < n; i++){
            water += Math.Min(leftMax[i], rightMax[i]) - height[i];
        }

        return water;
    }
}