public class Solution {
    public int FindDuplicate(int[] nums) {
        Dictionary<int, int> dict = new();

        for(int i=0; i < nums.Length; i++){
            if(! dict.ContainsKey(nums[i])){
                dict.Add(nums[i], 1);
            } else {
                dict[nums[i]] += 1;
            }
        }

        KeyValuePair<int, int> max = new KeyValuePair<int, int>(); 
        foreach (var kvp in dict)
        {
        if (kvp.Value > max.Value)
            max = kvp;
        }
        return max.Key;
    }
}
