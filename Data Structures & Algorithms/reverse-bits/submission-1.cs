public class Solution {
    public uint ReverseBits(uint n) {
        int res = 0;

        for(int i =0; i < 32; i++){
            var bitExtracted = ((n >> i ) & 1);
            if(bitExtracted == 1){
                res |= (1 << ((31 - i)));
            }
        }

        return (uint)res;
    }
}
