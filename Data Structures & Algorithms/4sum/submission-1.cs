public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        HashSet<(int, int, int, int)> seen = new();
        List<List<int>> result = new();
        int n = nums.Length;
        for (int a = 0; a < n; a++)
        {
            for (int b = a + 1; b < n; b++)
            {
                for (int c = b + 1; c < n; c++)
                {
                    for (int d = c + 1; d < n; d++)
                    {
                        long sum = (long)nums[a] + nums[b] + nums[c] + nums[d];
                        if (sum == target)
                        {
                            var quad = new[] {nums[a], nums[b], nums[c], nums[d]};
                            Array.Sort(quad);
                            var tuple = (quad[0], quad[1], quad[2], quad[3]);

                            if (!seen.Contains(tuple)) {
                                seen.Add(tuple);
                                result.Add(new List<int>{quad[0], quad[1], quad[2], quad[3]});
                            } 
                        }
                    }
                }
            }
        }

        return result;
           
    }
}