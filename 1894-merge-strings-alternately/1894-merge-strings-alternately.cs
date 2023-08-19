public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int size1 = word1.Length;
        int size2 = word2.Length;
        int size = size1 + size2;
        StringBuilder s = new StringBuilder(size);
        int i1 = 0, i2 = 0;
        for(int i = 0; i < size; i++) {
            if((i % 2 == 0 && i1 < size1) || i2 >= size2){
                s.Insert(i, word1[i1]);
                i1++;
            }
            else {
                s.Insert(i, word2[i2]);
                i2++;
            }
        }
        Console.WriteLine(s.Length);
        return s.ToString();
    }
}