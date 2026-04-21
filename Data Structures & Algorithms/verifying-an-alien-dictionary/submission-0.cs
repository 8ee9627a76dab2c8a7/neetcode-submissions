public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        int[] orderIndex = new int[26];
        for (int i = 0; i < order.Length; i++) {
            orderIndex[order[i] - 'a'] = i;
        }

        string[] sortedWords = (string[])words.Clone();
        Array.Sort(sortedWords, (w1, w2) => {
            for (int i = 0; i < Math.Min(w1.Length, w2.Length); i++) {
                if (w1[i] != w2[i]) {
                    return orderIndex[w1[i] - 'a'] - orderIndex[w2[i] - 'a'];
                }
            }
            return w1.Length - w2.Length;
        });

        for (int i = 0; i < words.Length; i++) {
            if (!words[i].Equals(sortedWords[i])) {
                return false;
            }
        }

        return true;
    }
}