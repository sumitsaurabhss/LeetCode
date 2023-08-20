public class Solution {
    public int[] DiStringMatch(string s) {
        int I = 0, D = s.Length;
        int size = D + 1;
        int[] array = new int[size];
        for(int i = 0; i < size-1; i++) {
            if(s[i] == 'I') {
                array[i] = I;
                I++;
            }
            else {
                array[i] = D;
                D--;
            }
        }
        array[size-1] = I;
        return array;
    }
}