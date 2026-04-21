public class Solution {

    public void SubsetSum(int index, List<int> subset, 
                        int[] nums, int remainingTarget, 
                        List<List<int>> result)
    {
        

        if(remainingTarget == 0){
            result.Add(new List<int>(subset));
            return;
        }

        if(index >= nums.Length || remainingTarget < 0){
            return;
        }

        
        subset.Add(nums[index]);
        SubsetSum(index, subset, nums, remainingTarget - nums[index], result);

        subset.RemoveAt(subset.Count - 1);
        SubsetSum(index + 1,subset, nums, remainingTarget , result);
    }

    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> result = new List<List<int>>();
        List<int> subset = new List<int>();
        SubsetSum(0, subset, nums, target, result); 
        return result;       
    }
}
