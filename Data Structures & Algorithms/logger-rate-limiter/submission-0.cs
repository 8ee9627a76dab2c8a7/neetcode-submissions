public class Logger {
    Dictionary<string, int> cache;
    public Logger() {
        cache = new Dictionary<string, int>();
    }

    public bool ShouldPrintMessage(int timestamp, string message) {
        if(cache.TryGetValue(message, out int stored)){
            if(timestamp - stored >= 10){
                cache[message] = timestamp;
                return true;
            }
            
        } else{
            cache[message] = timestamp;
            return true;
        }

        return false;
    }
}

/**
 * Your Logger object will be instantiated and called as such:
 * Logger obj = new Logger();
 * bool param_1 = obj.ShouldPrintMessage(timestamp, message);
 */
