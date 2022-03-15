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

	public virtual int PayMoney(int toPay)
	{
		// Console.WriteLine(toPay);

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

	public override int PayMoney(int amount)
	{
		return Money -= (int)Math.Floor(amount / 2.0);
	}

	public static void AddMoney(Person person, int amount)
	{
		person.Money += amount;

	}
}