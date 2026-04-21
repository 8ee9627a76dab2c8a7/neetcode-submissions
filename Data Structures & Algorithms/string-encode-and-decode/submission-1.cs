public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        if(strs.Count == 0){
            return sb.ToString();
        }

        foreach(var s in strs){
            var count = s.Length;
            sb.Append(count);
            sb.Append("#");
            sb.Append(s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> decode_msg = new List<string>();

        int i=0;
        while(i < s.Length)
        {
            var separator = s.IndexOf("#", i);
            var index = separator - i;
            var lengthWord = s.Substring(i, separator - i);
            var length = int.Parse(lengthWord);
            var word = s.Substring(separator + 1, length);
            decode_msg.Add(word);
            i = length + 1 + separator;
        }

        return decode_msg;
   }
}
