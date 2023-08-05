public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        // Console.WriteLine(s);
        // return true;
        int i = 0;
        int n = s.Length - 1;
        bool flag = true;
        while(i < n) {
            // Console.Write($"{i} - {s[i]} {n} - {s[n]}\t");
            // Console.Write($"{s[i] < 'a'} - {s[i] > 'z'} {s[i] < '0'} - {s[i] > '9'}\t");
            if((s[i] < 'a' || s[i] > 'z') && (s[i] < '0' || s[i] > '9'))  i++;
            else if((s[n] < 'a' || s[n] > 'z') && (s[n] < '0' || s[n] > '9'))  n--;
            else if(s[i] != s[n]) {
                flag = false;
                break;
            }
            else {
                i++;
                n--;
                Console.Write($"{i} {n}\t");
            }
                Console.Write($"{i} {n}\t");
        }
                Console.Write($"{i} {n}\t");
        return flag;
    }
}