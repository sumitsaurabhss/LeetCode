public class Solution {
    public double Average(int[] salary) {
        Array.Sort(salary);
        int sum = 0;
        int size = salary.Length;
        for(int i = 1; i < size-1; i++)  sum += salary[i];
        return (sum / (double)(size-2));
    }
}