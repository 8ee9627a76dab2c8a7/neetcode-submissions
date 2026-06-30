public class Solution {
    public int MostBooked(int n, int[][] meetings) {
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));
        long[] rooms = new long[n]; // end times of meetings in rooms
        int[] meetingCount = new int[n];

        foreach (var meeting in meetings) {
            int start = meeting[0], end = meeting[1];
            int minRoom = 0;
            bool found = false;

            for (int i = 0; i < n; i++) {
                if (rooms[i] <= start) {
                    meetingCount[i]++;
                    rooms[i] = end;
                    found = true;
                    break;
                }
                if (rooms[minRoom] > rooms[i]) {
                    minRoom = i;
                }
            }

            if (!found) {
                meetingCount[minRoom]++;
                rooms[minRoom] += end - start;
            }
        }

        int maxIndex = 0;
        for (int i = 1; i < n; i++) {
            if (meetingCount[i] > meetingCount[maxIndex]) {
                maxIndex = i;
            }
        }

        return maxIndex;
    }
}