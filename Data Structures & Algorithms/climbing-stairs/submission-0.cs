public class Solution {
    public Dictionary<int, int> hashMap = new Dictionary<int, int>();
    public int ClimbStairs(int n) {
        if(n <= 1) return 1;

        if(hashMap.ContainsKey(n)){
            return hashMap[n];
        }

        hashMap.Add(n, (ClimbStairs(n - 1) + ClimbStairs(n - 2)) );
        return hashMap[n];      
    }
}
