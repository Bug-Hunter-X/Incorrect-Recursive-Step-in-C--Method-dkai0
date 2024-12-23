public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0) {
            return b; 
        }
        if (b == 0) {
            return a; 
        }
        return MyMethod(a - 1, b) + 1; // Corrected recursive step
    }
}