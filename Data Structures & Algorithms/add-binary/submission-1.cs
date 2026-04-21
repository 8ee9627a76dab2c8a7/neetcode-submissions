public class Solution {
    public string AddBinary(string a, string b) {
        long elem1 = Convert.ToInt64(a, 2);
        long elem2 = Convert.ToInt64(b, 2);

        return Convert.ToString(elem1 + elem2, 2);
    }
}