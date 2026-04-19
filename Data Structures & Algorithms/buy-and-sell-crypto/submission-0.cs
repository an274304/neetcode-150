public class Solution {
    public int MaxProfit(int[] prices) {
        // Stores the maximum profit found so far
        int maxProfit = 0;

        // Outer loop → choose the day to BUY
        for(int i = 0; i < prices.Length; i++){
            int buy = prices[i]; // price at which we buy

            // Inner loop → choose the day to SELL (after buying)
            for(int j = i + 1; j < prices.Length; j++){
                int sell = prices[j]; // price at which we sell

                // Update max profit if current transaction is better
                maxProfit = Math.Max(maxProfit, (sell - buy));
            } 
        }

        // Return the best profit possible
        return maxProfit;
    }
}