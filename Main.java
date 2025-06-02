import java.io.IO;

public class Main {
    void main(String[] args) {
        String key = "Java";
        int tableSize = 7;
        int hash = 0;

        for (String string : key.split("")) {
            hash = (hash + string.hashCode()) % tableSize;
        }
        
        IO.println("Hash value for key '" + key + "' is: " + hash);
    }
}
