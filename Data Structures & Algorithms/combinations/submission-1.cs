public class Solution {

    public void backtrack(int index, List<int> currentSubset, List<List<int>> result, int n, int k)
    {
        if(currentSubset.Count == k)
        {
            result.Add(new List<int>(currentSubset));
            return;
        }

        for(int i = index; i <= n; i++){
            currentSubset.Add(i);
            backtrack(i + 1, currentSubset, result, n, k);
            currentSubset.RemoveAt(currentSubset.Count - 1);
        }
    }


    public List<List<int>> Combine(int n, int k) {
        List<List<int>> result = new();
        backtrack(1, new List<int>(), result ,n, k);
        return result;
    }
}