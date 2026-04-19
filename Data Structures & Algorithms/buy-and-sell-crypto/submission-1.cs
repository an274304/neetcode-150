public class Solution {
    public int MaxProfit(int[] prices) {
        // left = day to BUY (lowest price so far)
        // right = day to SELL (current day we are evaluating)
        int left = 0;
        int right = 1;

        // Stores the maximum profit found
        int maxProfit = 0;

        // Traverse the array once
        while(right < prices.Length){

            // If selling today is profitable
            if(prices[left] < prices[right]){
                int profit = prices[right] - prices[left];

                // Update maximum profit
                maxProfit = Math.Max(maxProfit, profit);
            }
            else{
                // Found a lower price → better day to buy
                left = right;
            }

            // Move to next day
            right++;
        }

        return maxProfit;
    }
}