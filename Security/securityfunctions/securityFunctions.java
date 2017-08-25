package securityfunctions;

import java.util.*;

public class securityFunctions {

    static int calculate(int x) {
        
    	int y = x % 11;
    	return y;
    }
    
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int x = in.nextInt();
        int result = calculate(x);
        System.out.println(result);
        in.close();
    }
}