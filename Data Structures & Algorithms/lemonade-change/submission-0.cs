public class Solution {
    public bool LemonadeChange(int[] bills) {
        int five = 0, ten = 0;
        foreach (int b in bills) {
            if (b == 5) {
                five++;
            } else if (b == 10) {
                ten++;
                if (five > 0) {
                    five--;
                } else {
                    return false;
                }
            } else {
                int change = b - 5;
                if (change == 15 && five > 0 && ten > 0) {
                    five--;
                    ten--;
                } else if (change == 15 && five >= 3) {
                    five -= 3;
                } else {
                    return false;
                }
            }
        }
        return true;
    }
}