class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("\n\n================================================================================");
		Console.WriteLine(
			"\n\n**As Assigned**\n\n" +
			"Create a new person demonstrating the default Person constructor (which sets \n" +
			"Money to 10000) and the PayMoney method for non-employee (full amount). \n");

		Person myPerson1 = new Person();
		Console.WriteLine($"\tmyPerson1 Initial Funding = {myPerson1.Money,0:D}");
		int amoutToPayPerson1 = 111;
		myPerson1.PayMoney(amoutToPayPerson1);
		Console.WriteLine($"\tAmount to Pay Out is {amoutToPayPerson1,0:D} pennies.");
		Console.WriteLine($"\tmyPerson1 Balance (After Paying {amoutToPayPerson1,0:D}) = {myPerson1.Money,0:D}");
		Console.WriteLine("\n\n================================================================================");



		Console.WriteLine(
			"\n\n**As Assigned**\n\n" +
			"Create a new employee demonstrating the default Employee constructor \n" +
			"passing an employee ID (e.g., 333),  which in turn calls the default Person \n" +
			"constructor (which sets Money to 10000) and the PayMoney method for  \n" +
			"employee (half amount). \n");

		Employee myEmployee1 = new Employee(333);
		Console.WriteLine($"\tmyEmployee1 ID = {myEmployee1.EmployeeID,0:D}");
		Console.WriteLine($"\tmyEmployee1 Initial Funding = {myEmployee1.Money,0:D}");
		int amoutToPay1 = 75;
		myEmployee1.PayMoney(amoutToPay1);
		Console.WriteLine($"\tmyEmployee1 Balance (After Paying Half of {amoutToPay1,0:D}) = {myEmployee1.Money,0:D}");
		Console.WriteLine("\n\n================================================================================");



		Console.WriteLine(
			"\n\n**Extra Credit Maybe**\n\n" +
			"Create a second new person demonstrating an overloaded Person \n" +
			"constructor which accepts an integer parameter specifying an \n" +
			"initial Money value (e.g., 33333) and the PayMoney method \n" +
			"for non-employee (full amount). \n");

		Person myPerson2 = new Person(33333);
		Console.WriteLine($"\tmyPerson2 Initial Funding = {myPerson2.Money,0:D}");
		int amoutToPayPerson2 = 222;
		myPerson2.PayMoney(amoutToPayPerson2);
		Console.WriteLine($"\tmyPerson2 Balance (After Paying {amoutToPayPerson2,0:D}) = {myPerson2.Money,0:D}");
		Console.WriteLine("\n\n================================================================================");



		Console.WriteLine(
			"\n\n**Extra Credit Maybe**\n\n" +
			"Create a second new employee using the overloaded  \n" +
			"Employee constructor which accepts BOTH an employee ID (e.g., 999) \n" +
			"AND an initial amount (e.g., 1500) which in turn calls the \n" +
			"overloaded Person constructor, and the PayMoney method for  \n" +
			"employee (half amount). \n");

		Employee myEmployee2 = new Employee(999, 1500);
		Console.WriteLine($"\tmyEmployee2 ID = {myEmployee2.EmployeeID,0:D}");
		Console.WriteLine($"\tmyEmployee2 Initial Funding = {myEmployee2.Money,0:D}");
		int amoutToPay2 = 101;
		myEmployee2.PayMoney(amoutToPay2);
		Console.WriteLine($"\tmyEmployee2 Balance (After Paying Half of {amoutToPay2,0:D}) = {myEmployee2.Money,0:D}");
		Console.WriteLine("\n\n================================================================================");



		Console.WriteLine(
			"\n\n**As Assigned**\n\n" +
			"Demonstrate the AddMoney method adding a different amount \n" +
			"to each Person (both employee and non-employee) ... showing \n" +
			"each instance of Person tracking their own amount. \n" );

		int amountToAddPerson1 = 444;
		int amountToAddPerson2 = 555;
		int amountToAddEmployee1 = 666;
		int amountToAddEmployee2 = 777;

		Person.AddMoney(myPerson1, amountToAddPerson1);
		Person.AddMoney(myPerson2, amountToAddPerson2);
		Person.AddMoney(myEmployee1, amountToAddEmployee1);
		Person.AddMoney(myEmployee2, amountToAddEmployee2);

		Console.WriteLine($"\tmyPerson1 Balance (After Adding {amountToAddPerson1,0:D}) = {myPerson1.Money,0:D}");
		Console.WriteLine($"\tmyPerson2 Balance (After Adding {amountToAddPerson2,0:D}) = {myPerson2.Money,0:D}");
		Console.WriteLine($"\tmyEmployee1 (ID: {myEmployee1.EmployeeID,0:D}) Balance (After Adding {amountToAddEmployee1,0:D}) = {myEmployee1.Money,0:D}");
		Console.WriteLine($"\tmyEmployee2 (ID: {myEmployee2.EmployeeID,0:D}) Balance (After Adding {amountToAddEmployee2,0:D}) = {myEmployee2.Money,0:D}");
		Console.WriteLine("\n\n================================================================================");

	}
}
