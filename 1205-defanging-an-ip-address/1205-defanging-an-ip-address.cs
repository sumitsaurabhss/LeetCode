public class Solution {
    public string DefangIPaddr(string address) {
        int size = address.Length;
        StringBuilder s = new StringBuilder(address);
        s.Replace(".", "[.]");
        return s.ToString();
    }
}