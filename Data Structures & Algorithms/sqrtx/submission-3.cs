public class Solution {
    public int MySqrt(int x) {
        int low = 1;
        int high = x;
        int res = 1;
        
        if( x == 0) return 0;


        while( low <= high){
            int mid = low + (high - low) / 2;
            long square = (long)mid * mid;
            if( square <= x){
                res = mid;
                low = mid + 1;
            } else {
                high = mid - 1;
            }
        }        

        return res;
    }
}