public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        List<int> result = new List<int>();
        int lp = 0; 
        int rp = arr.Length-1;
        while(rp - lp + 1 > k){
            if(Math.Abs(arr[lp] - x) > Math.Abs(arr[rp] - x)){
                lp++;
            } else{
                rp--;
            }
        }

        for(int i=lp; i <= rp; i++){
            result.Add(arr[i]);
        }

        return result;
    }
}