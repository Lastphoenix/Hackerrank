package matchingspecificstring;

import java.util.Scanner;
import java.util.regex.*;

public class regex {

	public void checker(String Regex_Pattern){

		Scanner sc = new Scanner(System.in);
		String Test_String = sc.nextLine();
		Pattern p = Pattern.compile(Regex_Pattern);
		Matcher m = p.matcher(Test_String);
		int Count = 0;
		while(m.find()){
			Count += 1;
		}
		System.out.format("Number of matches : %d",Count);
		sc.close();
	}   

	public static void main(String[] args) {

		regex tester = new regex();
		tester.checker("hackerrank");		

	}
}