class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("");
		Console.WriteLine(
			"\n\nCreate a new person demonstrating the default constructor \n" +
			"amount of 10000 and the PayMoney method for non-employee (full amount). \n" +
			"===========================\n");

		Person myPerson1 = new Person();
		Console.WriteLine($"\tmyPerson1 Initial Funding = {myPerson1.Money,0:D}");
		int amoutToPayPerson1 = 111;
		myPerson1.PayMoney(amoutToPayPerson1);
		Console.WriteLine($"\tmyPerson1 Balance (After Paying {amoutToPayPerson1,0:D}) = {myPerson1.Money,0:D}");



		Console.WriteLine(
			"\n\nCreate a second new person passing an initial amount of 33333\n" +
			"to the constructor and the PayMoney method for non-employee (full amount). \n" +
			"===========================\n");

		Person myPerson2 = new Person(33333);
		Console.WriteLine($"\tmyPerson2 Initial Funding = {myPerson2.Money,0:D}");
		int amoutToPayPerson2 = 222;
		myPerson2.PayMoney(amoutToPayPerson2);
		Console.WriteLine($"\tmyPerson2 Balance (After Paying {amoutToPayPerson2,0:D}) = {myPerson2.Money,0:D}");



		Console.WriteLine(
			"\n\nCreate a new employee passing an employee ID of 333 \n" +
			"to the constructor, setting inital amount to 500, and  \n" +
			"the PayMoney method for employee (half amount). \n" +
			"===========================\n");

		Employee myEmployee1 = new Employee(333);
		myEmployee1.Money = 500;
		Console.WriteLine($"\tmyEmployee1 ID = {myEmployee1.EmployeeID,0:D}");
		Console.WriteLine($"\tmyEmployee1 Initial Funding = {myEmployee1.Money,0:D}");
		int amoutToPay = 21;
		myEmployee1.PayMoney(amoutToPay);
		Console.WriteLine($"\tmyEmployee1 Balance (After Paying Half of {amoutToPay,0:D}) = {myEmployee1.Money,0:D}");



		Console.WriteLine(
			"\n\nCreate a second new employee demonstrating the default constructor \n" +
			"amount of 10000 and the PayMoney method for non-employee (full amount). \n" +
			"===========================\n");

		Employee myEmployee2 = new Employee(666);
		Console.WriteLine($"\tmyEmployee2 ID = {myEmployee2.EmployeeID,0:D}");
		Console.WriteLine($"\tmyEmployee2 Initial Funding = {myEmployee2.Money,0:D}");
		int amoutToPay2 = 75;
		myEmployee2.PayMoney(amoutToPay2);
		Console.WriteLine($"\tmyEmployee2 Balance (After Paying Half of {amoutToPay2,0:D}) = {myEmployee2.Money,0:D}");



		Console.WriteLine(
			"\n\nDemonstrate the AddMoney method adding a different amount \n" +
			"to each employee ... showing each instance of Employee tracking its own amount. \n" +
			"===========================\n");

		int amountToAddEmployee1 = 444;
		int amountToAddEmployee2 = 555;

		Employee.AddMoney(myEmployee1, amountToAddEmployee1);
		Employee.AddMoney(myEmployee2, amountToAddEmployee2);
		Console.WriteLine($"\tmyEmployee1 (ID: {myEmployee1.EmployeeID,0:D}) Balance (After Adding {amountToAddEmployee1,0:D}) = {myEmployee1.Money,0:D}");
		Console.WriteLine($"\tmyEmployee2 (ID: {myEmployee2.EmployeeID,0:D}) Balance (After Adding {amountToAddEmployee2,0:D}) = {myEmployee2.Money,0:D}");
		Console.WriteLine("\n\n\n");

	}
}
