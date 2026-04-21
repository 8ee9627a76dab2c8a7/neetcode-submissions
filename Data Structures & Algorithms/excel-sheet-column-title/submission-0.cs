public class Solution {
    public string ConvertToTitle(int columnNumber) {
        StringBuilder sb = new StringBuilder();
        while (columnNumber > 0) {
            // Extraire le dernier "chiffre" (lettre)
            int remainder = (columnNumber - 1) % 26;
            char letter = (char)('A' + remainder);
            sb.Append(letter);
            columnNumber = (columnNumber - 1) / 26;
        }

        char[] charArray = sb.ToString().ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        return reversedString;

    }
}