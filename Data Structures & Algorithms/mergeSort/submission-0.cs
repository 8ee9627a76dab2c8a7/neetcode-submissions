// Definition for a pair.
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {

    private List<Pair> Merge(List<Pair> left, List<Pair> right) 
    {
        List<Pair> result = new List<Pair>();
        int i = 0;
        int j = 0;
        while (i < left.Count && j < right.Count) {
            // Compare et prends le plus petit
            if(left[i].Key <= right[j].Key){
                result.Add(left[i]);
                i++;
            } else {
                result.Add(right[j]);
                j++;
            }
        }

        result.AddRange(left.GetRange(i, left.Count - i));
        result.AddRange(right.GetRange(j, right.Count - j));

        return result;
    }

    public List<Pair> MergeSort(List<Pair> pairs) {
        // base case
        if (pairs.Count <= 1) return pairs;
        int mid = pairs.Count / 2;

        List<Pair> left = pairs.GetRange(0, mid);
        List<Pair> right = pairs.GetRange(mid, pairs.Count - mid);

        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(left, right);
    }

}
