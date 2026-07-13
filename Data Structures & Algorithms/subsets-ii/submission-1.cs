public class Solution {
    List<List<int>> res = new List<List<int>>();
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        Backtrack(0, new List<int>(), nums);
        return res;
    }

    public void Backtrack(
        int index, 
        List<int> subset, 
        int[] nums)
    {
        res.Add(new List<int>(subset));

        for(int i = index; i < nums.Length; i++)
        {
            if( i > index && nums[i] == nums[i -1]){
                continue;
            }

            subset.Add(nums[i]);
            Backtrack(i + 1, subset, nums);
            subset.RemoveAt(subset.Count - 1);
        }
    }
}
