public class Solution {
    public int MinOperations(string[] logs) {
        int depth = 0;
        foreach(var log in logs){
            if(log == "../"){
                if(depth > 0) depth--;
            } else if(log == "./"){
                continue;
            } else{
                depth++;
            }
        }

        return depth;
    }
}