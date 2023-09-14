public class Solution {
    public string SortSentence(string s) {
        string res="";
        string[] words=s.Split();
        Dictionary<int,string> d=new Dictionary<int,string>();
        foreach(string word in words)
        {
            d.Add(word[word.Length-1]-'0',word.Substring(0,word.Length-1));
        }
        for(int i=1;i<words.Count()+1;i++)
        {
            res+=d[i]+" ";
        }
        return res.Trim();
    }
}