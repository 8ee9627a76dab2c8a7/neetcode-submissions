public class Solution {
    public List<List<int>> Combine(int n, int k) {
        List<List<int>> res = new List<List<int>>();

        void Backtrack(int i, List<int> comb) {
            if (i > n) {
                if (comb.Count == k) {
                    res.Add(new List<int>(comb));
                }
                return;
            }

            comb.Add(i);
            Backtrack(i + 1, comb);
            comb.RemoveAt(comb.Count - 1);
            Backtrack(i + 1, comb);
        }

        Backtrack(1, new List<int>());
        return res;
    }
}