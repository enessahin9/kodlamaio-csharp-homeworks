using Interfaces;

CustomerManager customerManager = new CustomerManager();
customerManager.Add(new OracleCustomerDal());
customerManager.Add(new SqlServerCustomerDal());


ICustomerDal[] customerDals = new ICustomerDal[2]
{
	 new SqlServerCustomerDal(),
	 new OracleCustomerDal()

};

PersonManager personManager = new PersonManager();
personManager.Add(new Customer
{
	Id = 1,
	FirstName = "Enes",
	LastName = "Şahin",
	Addrress = "Bursa"
});


Student student = new Student
{
	Id = 1,
	FirstName = "Enes",
	LastName = "Şahin",
	Departmant = "IT"
};

personManager.Add(student);

Console.ReadLine();

// Soyut bir nesnedir. Tek basina bir sey ifade etmez.
interface IPerson
{
	int Id { get; set; }
	string FirstName { get; set; }
	string LastName { get; set; }
}

// Somut bir nesnedir. 
class Customer : IPerson
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Addrress { get; set; }
}

// Somut bir nesnedir.
class Student : IPerson
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Departmant { get; set; }
}

class Worker : IPerson
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Departmant { get; set; }
}

class PersonManager
{
	public void Add(IPerson person)
	{
		Console.WriteLine(person.FirstName + " eklendi!");
	}
}