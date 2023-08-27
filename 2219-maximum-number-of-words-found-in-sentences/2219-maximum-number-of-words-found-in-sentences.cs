public class Solution {
    public int MostWordsFound(string[] sentences) {
        int L = sentences.Length;
        int max = 0, c = 0;
        for(int i = 0; i < L; i++) {
            c = 1;
            int l = sentences[i].Length;
            for(int j = 0; j < l; j++) {
                if(sentences[i][j] == ' ')
                    c++;
            }
            //Console.WriteLine($"{c} {max} ");
            if(c > max)
                max = c;
        }
        return max;
    }
}