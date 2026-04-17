public class Solution {
    public int MaxArea(int[] heights) {

        // 🔹 Initialize result (maximum area)
        int res = 0;

        // 🔹 Two pointers: start at left, end at right
        int start = 0;
        int end = heights.Length - 1;

        // 🔹 Iterate while pointers do not cross
        while(start < end){

            // 🔹 Calculate current area
            // Height is limited by the shorter line
            // Width = distance between pointers
            int area = Math.Min(heights[start], heights[end]) * (end - start);

            // 🔹 Update maximum area
            res = Math.Max(res, area);

            // 🔹 Move the pointer pointing to the smaller height
            // Because:
            // - Area depends on min height
            // - Moving taller line won't increase height, but reduces width
            if(heights[start] < heights[end]){
                start++;
            }
            else{
                end--;
            }
        }

        return res;
    }
}