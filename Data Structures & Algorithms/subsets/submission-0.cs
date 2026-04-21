public class Solution {
    public void backtrack(int index, List<int> currentSubset, List<List<int>> result, int[] nums)
    {
        if(index == nums.Length)
        {
            result.Add(new List<int>(currentSubset));
            return;
        }

        backtrack(index + 1, currentSubset, result, nums);
        currentSubset.Add(nums[index]);
        backtrack(index + 1, currentSubset, result, nums);
        currentSubset.RemoveAt(currentSubset.Count - 1);
    }

    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new();
        backtrack(0, new List<int>(), result ,nums);
        return result;
    }
}
