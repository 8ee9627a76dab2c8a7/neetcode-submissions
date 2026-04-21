// Definition for a pair
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
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        List<List<Pair>> result = new();
        if(pairs.Count == 0){
            return new List<List<Pair>>();
        }
        result.Add(new List<Pair>(pairs));
        for(int i = 1; i < pairs.Count; i++){
            Pair key = pairs[i];  
            int j = i -1;
            while( j >= 0 && pairs[j].Key > key.Key){
                pairs[j+1] = pairs[j];
                j--;
            }

            pairs[j + 1] = key;
            result.Add(new List<Pair>(pairs));
        }

        return result;
    }
}
