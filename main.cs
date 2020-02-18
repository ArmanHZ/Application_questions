using System;
					
public class Program {
	public static void Main() {
		Program program = new Program();

		int firstInput;
		int secondInput;
		try {
			Console.Write("Please enter the first Integer: ");
			firstInput = Convert.ToInt32(Console.ReadLine());
			Console.Write("Please enter the second Integer: ");
			secondInput = Convert.ToInt32(Console.ReadLine());
			program.swapElements(ref firstInput, ref secondInput);
		} catch (FormatException e) {
			Console.Write("Please enter an Integer.", e);
			System.Environment.Exit(-1);
		}
	}

	public void swapElements(ref int firstInput, ref int secondInput) {
		Console.WriteLine("Before swapping.\nValue of firstInput = " + firstInput + "\nValue of secondInput = " + secondInput + "\n");
		firstInput = firstInput + secondInput;
		secondInput = firstInput - secondInput;
		firstInput = firstInput - secondInput;

		Console.WriteLine("After swapping.\nValue of firstInput = " + firstInput + "\nValue of secondInput = " + secondInput + "\n");
	}
}

