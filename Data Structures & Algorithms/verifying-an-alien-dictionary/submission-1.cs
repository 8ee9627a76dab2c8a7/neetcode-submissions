public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        Dictionary<char, int> orderMap = new();
        bool flagged = false;
        for(int i=0; i < order.Length; i++){
            orderMap[order[i]] = i;
        }

        for(int j=0; j < words.Length-1; j++){
            
            for(int k=0; k < words[j].Length && k < words[j+1].Length; k++)
            {
                Console.WriteLine($"{words[j][k]} -> {orderMap[words[j][k]]}");
                Console.WriteLine($"{words[j+1][k]} -> {orderMap[words[j+1][k]]}");
                if(words[j][k] != words[j+1][k])
                {
                    flagged = true;
                    if(orderMap[words[j][k]] > orderMap[words[j + 1][k]])
                    {
                        return false;
                    } else {
                        break;
                    }
                }
            }

            if(!flagged && words[j].Length > words[j+1].Length)
            {
                return false;
            } 
        }

        return true;
    }
}