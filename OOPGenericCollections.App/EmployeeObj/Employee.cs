// Tobias Skog - .NET23

namespace OOPGenericCollections.App.EmployeeObj
{
  // New class Employee
  public class Employee
  {
    // The Employee class attributes are all private to keep it encapsulated
    // with private get and set accessors
    private string _name { get; set; }
    private string _gender { get; set; }
    private int _id { get; set; }
    private double _salary { get; set; }

    // Constructor for the Employee class
    // Takes a string name, string gender, int id and double salary as input
    // Assigns values recieved to the private attributes of the class
    public Employee(string name, string gender, int id, double salary)
    {
      _name = name;
      _gender = gender;
      _id = id;
      _salary = salary;
    }

    // Public accessors for the user to be able to get access to the name,
    // gender, id and salary outside the scope of the class
    public string Name { get { return _name; } }
    public string Gender { get { return _gender; } }
    public int Id { get { return _id; } }
    public double Salary { get { return _salary; } }

    // public method ToStringP1() that will write to the console
    // with our desired format specified in the assignment
    public override string ToString()
    {
      return $"{_id} - {_name} - {_gender} - {_salary}";
    }

    // method to print the new layout of the assignment in part 2
    // public override method ToString() that will write to the console
    // with our desired format specified in the assignment and being able
    // to use our validation library to call ToString
    //public override string ToString()
    //{
    //  return $"ID = {Id}, Name = {Name}, Gender = {Gender}, Salary = {Salary}";
    //}
  }
}
