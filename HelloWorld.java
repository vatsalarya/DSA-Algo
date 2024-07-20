import java.util.Scanner;

public class HelloWorld {

    public static void main(String[] args) {
        System.out.println(Factorial(10));
    }

    public static int Factorial(int number){
        if(number == 1){
            return 1;
        }
        return number*Factorial(number-1);
    }
}