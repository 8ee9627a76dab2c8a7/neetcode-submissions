static class Singleton {
    private static Singleton instance = null;
    private static final Object LOCK = new Object();
    private String value;

    private Singleton() {

    }

    public static Singleton getInstance() {
         if (instance == null) {
            synchronized (LOCK) {
                if (instance == null) {
                    instance = new Singleton();
                }
            }
        }
        return instance;
    }

    public String getValue() {
        return value;
    }

    public void setValue(String value) {
        this.value = value;
    }
    
}
