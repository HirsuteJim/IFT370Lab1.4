using System;
interface IPerson
{
	int PayMoney(int toPay);
}

class Person : IPerson
{
	public int Money { get; set; }

	public Person()
	{
		Money = 10000;
	}

	public Person(int starterAmount)
	{
		Money = starterAmount;
	}

	public static void AddMoney(Person person, int amount)
	{
		person.Money += amount;
	}

	public virtual int PayMoney(int toPay)
	{

		return Money -= toPay;
	}
}

class Employee : Person
{
	public int EmployeeID { get; set; }

	public Employee(int employeeID) : base()
	{
		EmployeeID = employeeID;
	}

	public Employee(int employeeID, int initialAmount) : base(initialAmount)
	{
		EmployeeID = employeeID;
	}

	public override int PayMoney(int amount)
	{
		return Money -= (int)Math.Floor(amount / 2.0);
	}
}