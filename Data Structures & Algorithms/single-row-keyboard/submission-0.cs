public class Solution {
    public int CalculateTime(string keyboard, string word) {
        int currentPos = 0;
        int totalTime = 0;
        Dictionary<char, int> dict = new();
        for( int i=0; i <= 25; i++){
            dict[keyboard[i]] = i;
        }

        foreach(var w in word){
            if(dict.ContainsKey(w)){
                int dist = Math.Abs(dict[w] - currentPos);
                
                currentPos = dict[w];
                totalTime += dist;
            }
        }

        return totalTime;
    }
}
