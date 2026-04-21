public class Solution {
    public int HammingWeight(uint n) {
        int count = 0;
        for(int i = 0; i < 32; i++){
            var bitMask = (1 << i) & n;
            if(bitMask > 0 ){
                count++;
            }
        }

        return count;
    }
}
