public class Solution {
    public int Reverse(int x) {
    long result = 0;
    
    while (x != 0) {
        int digit = x % 10;      // Dernier chiffre (garde le signe)
        x = x / 10;              // Enlève le dernier chiffre
        result = result * 10 + digit;
    }
    
    if (result > int.MaxValue || result < int.MinValue) return 0;
    return (int)result;
}
}
