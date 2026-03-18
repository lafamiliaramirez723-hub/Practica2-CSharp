import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("¿Cuántos números?: ");
        int n = sc.nextInt();

        int pares = 0;

        for (int i = 0; i < n; i++) {
            System.out.print("Número: ");
            int num = sc.nextInt();

            if (num % 2 == 0) {
                pares++;
            }
        }

        System.out.println("Pares: " + pares);
    }
}
