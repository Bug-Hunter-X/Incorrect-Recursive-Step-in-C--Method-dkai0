public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0) {
            return b; // Correct base case
        }
        if (b == 0) {
            return a; // Correct base case
        }
        return MyMethod(a - 1, b - 1); // Incorrect recursive step, should be a - 1, b
    }
}