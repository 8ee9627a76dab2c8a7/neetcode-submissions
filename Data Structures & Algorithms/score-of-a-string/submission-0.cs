public class Solution {
    public int ScoreOfString(string s) {
        int sum = 0;

        for(int i=0; i < s.Length -1; i++)
        {

            var diff = Math.Abs((int)s[i] - (int)s[i + 1]);
            sum += diff;
        }

        return sum;
    }
}