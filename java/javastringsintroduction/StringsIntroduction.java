package javastringsintroduction;

import java.io.*;

public class StringsIntroduction {

	public static void main(String[] args) throws IOException {
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String a = br.readLine();
		String b = br.readLine();
		
		int lengthStrings = a.length() + b.length();
		System.out.println(lengthStrings);
		
		if (a.charAt(0) > b.charAt(0)) {
			System.out.println("Yes");
		} else {
			System.out.println("No");
		}
		
		String aCap = a.substring(0, 1).toUpperCase() + a.substring(1);
		String bCap = b.substring(0, 1).toUpperCase() + b.substring(1);
		System.out.println(aCap + " " + bCap);
		
	}
}