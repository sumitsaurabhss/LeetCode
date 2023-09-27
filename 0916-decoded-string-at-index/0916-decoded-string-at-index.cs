// public class Solution {
//     public string DecodeAtIndex(string s, int k) {
//         StringBuilder sb = new StringBuilder();
//         int d = 0, n = s.Length;
//         Console.WriteLine($"{s}  {n}");
//         for(int i = 0; i < n; i++) {
//         Console.WriteLine($"{s[i]}  {sb}");
//             if(s[i] <= '9' && s[i] >= '0') {
//                 d = s[i] - '1';
//                 string cp = sb.ToString();
//                 while(d > 0) {
//                     Console.WriteLine($" --- {d}  {sb}");
//                     sb.Append(cp);
//                     d--;
//                 }
//             }
//             else  sb.Append(s[i]);
//         }
//         Console.WriteLine(sb);
//         return sb.ToString();
//     }
// }

public class Solution {
    public string DecodeAtIndex(string s, int k) {
        long length = 0;
        int i = 0;

        while (length < k) {
            if (char.IsDigit(s[i])) {
                length *= s[i] - '0';
            } else {
                length++;
            }
            i++;
        }

        for (int j = i - 1; j >= 0; j--) {
            if (char.IsDigit(s[j])) {
                length /= s[j] - '0';
                k %= (int)length;
            } else {
                if (k == 0 || k == length) {
                    return s[j].ToString();
                }
                length--;
            }
        }

        return "";
    }
}