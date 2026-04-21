public class Solution {
    public void SortColors(int[] nums) {
        int zeros = 0;
        int ones = 0;
        int twos = 0;
        for(int i=0; i< nums.Length; i++)
        {
            if(nums[i] == 0) zeros++;
            if(nums[i] == 1) ones++;
            if(nums[i] == 2) twos++;
        }
        int index = 0;
        while( index < nums.Length)
        {
            if(index < zeros) nums[index++] = 0; 
            else if(index < ones + zeros) nums[index++] = 1; 
            else if(index < zeros + ones + twos) nums[index++] = 2; 
        } 

        return;  
    }   
}