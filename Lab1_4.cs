using System;
	// Assigned Interface
	// Specifies the method PayMoney
	//		Accepts an integer parameter
	//		Returns an integer
interface IPerson
{
	int PayMoney(int toPay);
}

class Person : IPerson
{
	public int Money { get; set; }

	// Assigned Default Constructor
	// Assign the default value of 10000 to the Money property
	public Person()
	{
		Money = 10000;
	}

	// Extra — Not part of the assignment
	//
	// An overloaded constructor to accept an Initial Funding Amount
	//
	// 		Accept an input integer parameter for the employee ID
	// 		Assign the value of the received parameter to the Money property
	public Person(int starterAmount)
	{
		Money = starterAmount;
	}

	// Assigned Method
	// Accept an input Person parameter representing a person
	// Accept an input integer parameter representing an amount
	// Add the value of the received amount parameter to the Money property
	public static void AddMoney(Person person, int amount)
	{
		person.Money += amount;
	}

	// Assigned Method
	// Accept an input integer parameter representing an amount
	// Subtract the value of the received toPay parameter from the Money property
	// and return the new value of the Money property
	public virtual int PayMoney(int toPay)
	{

		return Money -= toPay;
	}
}

class Employee : Person
{
	public int EmployeeID { get; set; }

	// Assigned Constructor
	// Accept an input integer parameter for the employee ID
	// Call the base (Person) constructor
	// Assign the value of the received parameter to the EmployeeID property
	public Employee(int employeeID) : base()
	{
		EmployeeID = employeeID;
	}

	// Extra — Not part of the assignment
	// An overloaded constructor to accept BOTH Employee ID and Initial Funding Amount
	//
	// Call the overloaded base (Person) constructor passing the initial amount for
	// the employee.
	// Assign the value of the received employeeID parameter to the EmployeeID property
	public Employee(int employeeID, int initialAmount) : base(initialAmount)
	{
		EmployeeID = employeeID;
	}

	// Assigned Method
	// Override the Person.PayMoney method
	// Accept an input integer parameter representing an amount
	// Divide the value of the received amount parameter by 2 and
	// round down to the nearest integer
	// Subtract this new value from the Money property
	// and return the new value of the Money property
	public override int PayMoney(int amount)
	{
		return Money -= (int)Math.Floor(amount / 2.0);
	}
}