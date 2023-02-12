public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int[] buy = new int[n];
        buy[0] = prices[0];
        int[] sell = new int[n];
        sell[n-1] = prices[n-1];
        for(int i=1; i<n; i++){
            if(prices[i] > buy[i-1])  buy[i] = buy[i-1];
            else  buy[i] = prices[i];
            if(prices[n-i-1] < sell[n-i])  sell[n-i-1] = sell[n-i];
            else  sell[n-i-1] = prices[n-i-1];
        }
        // foreach(int v in buy)  Console.Write(v+" ");
        // Console.WriteLine();
        // foreach(int v in sell)  Console.Write(v+" ");
        int mx = 0, d = 0;
        for(int i=1; i<n; i++){
            d = sell[i] - buy[i-1];
            if(d > mx)  mx = d;
        }
        return mx;
    }
}