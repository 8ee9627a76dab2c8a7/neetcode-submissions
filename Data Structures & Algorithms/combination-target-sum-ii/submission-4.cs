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
        SubsetSum(index + 1, subset, nums, remainingTarget - nums[index], result);

        subset.RemoveAt(subset.Count - 1);

        int nextIndex = index + 1;
        while(nextIndex < nums.Length && nums[nextIndex] == nums[index]) {
            nextIndex++;
        }

        if (nextIndex < nums.Length && nums[nextIndex] > remainingTarget) {
            return; // Pas besoin d'explorer
        }

        SubsetSum(nextIndex,subset, nums, remainingTarget , result);
    }


    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        List<List<int>> result = new List<List<int>>();
        List<int> subset = new List<int>();
        SubsetSum(0, subset, candidates, target, result); 
        return result;       
    }
}
