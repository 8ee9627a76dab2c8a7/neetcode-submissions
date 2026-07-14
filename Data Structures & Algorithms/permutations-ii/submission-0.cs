public class Solution {
    public List<List<int>> PermuteUnique(int[] nums) {
        Array.Sort(nums);
        var res = new List<List<int>>();
        var current = new List<int>();
        var used = new bool[nums.Length];
        Backtrack();
        return res;

        void Backtrack() {
            if (current.Count == nums.Length) {
                res.Add(new List<int>(current));
                return;
            }
            for (int i = 0; i < nums.Length; i++) {
                if(used[i]) continue;
                if(i > 0 && nums[i] == nums[i - 1] && !used[i - 1]) continue;
                used[i] = true;
                current.Add(nums[i]);
                Backtrack();
                current.RemoveAt(current.Count -1);
                used[i] = false;
            }
        }
    }
}