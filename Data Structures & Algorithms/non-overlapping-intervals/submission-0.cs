public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        int count = 0;
        if (intervals.Length <= 1) 
            return count;

        // ranger les temps 
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        var current = intervals[0];

        for(int i=1; i < intervals.Length; i++){

            if(current[1] > intervals[i][0]){
                current[1] = Math.Min(current[1], intervals[i][1]);
                count++;
            } else{
                current = intervals[i];
            }
        }

        return count;
    }
}
