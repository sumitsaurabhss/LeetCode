public class Solution {
    public string Interpret(string command) {
        int i = 0, l = command.Length;
        StringBuilder s = new();
        while(i < l) {
            if(command[i] == 'G'){
                s.Append('G');
                i++;
            }
            else if(command[i] == '(' && command[i+1] == ')') {
                s.Append('o');
                i += 2;
            }
            else if(command[i] == '(' && command[i+1] == 'a') {
                s.Append("al");
                i += 4;
            }
        }
        return s.ToString();
    }
}