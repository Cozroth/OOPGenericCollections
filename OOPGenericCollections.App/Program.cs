// Tobias Skog - .NET23
using OOPGenericCollections.App.EmployeeObj;
using OOPGenericCollections.ValidationUtility;
namespace OOPGenericCollections.App
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Changing the Console Color to look like the assignment
      Console.ForegroundColor = ConsoleColor.Green;

      // Creatinga two new int variables that will be used later in the software for
      // writing a specific number or number of objects to the console
      int employeeNumber;

      // Creating 5 new Employee objects with different Names, Genders, IDs, and Salarys
      Employee Emp1 = new("Tobias", "Male", 52, 25);
      Employee Emp2 = new("Victor", "Male", 51, 16000);
      Employee Emp3 = new("Peder", "Male", 61, 22000);
      Employee Emp4 = new("Åsa", "Female", 56, 22000);
      Employee Emp5 = new("Jimmy", "Male", 42, 25000);

      // Creating an array of the Employees to quickly being able to add or remove them all from
      // a list or stack with a sepperate class "AddTo"
      Employee[] employees = { Emp1, Emp2, Emp3, Emp4, Emp5 };

      // Creating a new Stack of the Employee type
      Stack<Employee> stack = new();

      // Creating a new List of the Employee type
      List<Employee> list = new();

      // Writing out what section of the assignment we are at currently
      Console.WriteLine("=========== Part 1 ===========");

      // Using the sepperate class AddTo with its method AddObjectsToStack that takes an
      // an array of Employee objects and a Stack<Employee> that will add every object
      // in the array to the stack by looping thru them, does not return anything
      //LogicHandler.AddObjectsToStack(employees, stack);
      Console.WriteLine("------------------------------");
      StackValidationHelper.AddObjectsToStack(employees, stack);

      // foreach loop to look at each sepperate employee "e" in the stack
      // By using string interpolation $"{e}" we implicitly call the ToStringP1() method
      // and can exclude that in our Console.WriteLine code wich simplifies both the writing 
      // of the code and the reading of it
      // Writes all the current employee data out in the same format as the assignment
      // then adding a new line with `\n` and writing out the amount of items in the stack
      // by using the Stack.Count method to the console

      StackValidationHelper.ItemsLeftInStack(employees, stack);

      //foreach (Employee e in stack)
      //{
      //    Console.WriteLine($"{e}\nItems left in the Stack = {stack.Count}");
      //}

      // Writing out a line to the console, following the design of the assignment
      Console.WriteLine("------------------------------");

      // Informing the user what we are doing next
      Console.WriteLine("Retrive Using Pop Method");

      // Setting the count variable to the current number of objects in the stack

      //count = stack.Count;
      // for loop where we loop count times (the current unchanged amount of objects in the stack)
      // Removing the top element in the stack with stack.Pop()
      // Writing out to console the current amount of items left in the Stack after we removed the top element

      // The stack follows the Last-in, First-Out principle wich means that the most recently element added is the top element.

      StackValidationHelper.PopItemsInStack(stack, stack.Count);

      //for (int i = 0; i < count; i++)
      //{
      //    Console.WriteLine(stack.Pop());
      //    Console.WriteLine($"Items left in the Stack = {stack.Count}");
      //}

      // Using the sepperate class AddTo with its method AddObjectsToStack that takes an
      // an array of Employee objects and a Stack<Employee> that will add every object
      // in the array to the stack by looping thru them, does not return anything

      //LogicHandler.AddObjectsToStack(employees, stack);
      StackValidationHelper.AddObjectsToStack(employees, stack);

      // Writing out a line to the console, following the design of the assignment
      Console.WriteLine("------------------------------");
      Console.WriteLine("Retrive Using Peek Method");

      StackValidationHelper.PeekItemsInStack(stack, 2);

      //for (int i = 0; i < 2; i++)
      //{
      //    Console.WriteLine(stack.Peek().ToStringP1());
      //    Console.WriteLine($"Items left in the Stack = {stack.Count}");
      //}

      // Writing out a line to the console, following the design of the assignment
      Console.WriteLine("------------------------------");

      // The employee we want to search for is the third created "Emp3"
      // Assigning employeeNumber to 3, the employee we want to find
      employeeNumber = 3;


      // Writing out to console
      // Using Stack.Contains for the logic where we look at our employee array at the index employeeNumber - 1 (since arrays start a 0 and we started
      // the count of Employees at 1)
      // IF the employee we are searching for exists = $"Emp{employeeNumber} is in stack"
      // ELSE = $"Emp{employeeNumber} is not in stack"

      StackValidationHelper.StackContains(employees, stack, employeeNumber);
      //Console.WriteLine(stack.Contains(employees[employeeNumber - 1]) ? $"Emp{employeeNumber} is in stack" : $"Emp{employeeNumber} is not in stack");

      // Writing out a line to the console, following the design of the assignment
      Console.WriteLine("------------------------------");

      //---------------------------------------------------------------------------------------------------------------------------------------------------//
      // Del 2 - List
      // Using the sepperate class AddTo with its method AddObjectsToList that takes an
      // an array of Employee objects and a List<Employee> that will add every object
      // in the array to the List by looping thru them, does not return anything
      //LogicHandler.AddObjectsToList(employees, list);

      // Writing out what section of the assignment we are at currently
      Console.WriteLine("\n========================== Part 2 ==========================");

      ListValidationHelper.AddObjectsToList(employees, list);

      // The employee we want to search for is the third created "Emp2"
      // Assigning employeeNumber to 2, the employee we want to find
      employeeNumber = 2;


      Console.WriteLine("------------------------------------------------------------");
      // Writing out to console
      // Using List.Contains for the logic where we look at our employee array at the index employeeNumber - 1 (since arrays start a 0 and we started
      // the count of Employees at 1)
      // IF the employee we are searching for exists = $"Employee{employeeNumber} object exists in the list"
      // ELSE = $"Employee{employeeNumber} object does not exist in the list"
      ListValidationHelper.ListContains(employees, list, employeeNumber);

      Console.WriteLine("------------------------------------------------------------");

      // Using the sepperate class AddTo with its method FindFirstGenderInList that takes
      // a List<Employee> and a string with the Gender we are searching for
      // The method will write the result of the search to the console
      //LogicHandler.FindFirstGenderInList(list, "Male");


      // Using my own ValidationUtility Library with a method inside the ListValidationHelper
      // to get a the first item in a list with a specific value
      // First have to create a static string as a method to pass in to the method
      // so that it knows what we are looking for
      static string GetGender(Employee obj) => obj.Gender;
      var foundEmployee = ListValidationHelper.GetFirstInList(list, GetGender, "Male");
      if (foundEmployee != null)
      {
        Console.WriteLine($"ID = {foundEmployee.Id}, Name = {foundEmployee.Name}, Gender = {foundEmployee.Gender}, Salary = {foundEmployee.Salary}");
      }
      Console.WriteLine("------------------------------------------------------------");

      // Using the sepperate class AddTo with its method FindAllGenderInList that takes
      // a List<Employee> and a string with the Gender we are searching for
      // The method will return the result of the search
      var foundEmployeeList = ListValidationHelper.GetAllInList(list, GetGender, "Male");
      if (foundEmployee != null)
      {
        foreach (var employee in foundEmployeeList)
        {
          Console.WriteLine($"ID = {employee.Id}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
        }
      }
      Console.WriteLine("------------------------------------------------------------");

      //ListValidationHelper.FindAllInList(list, getGender, "Male"); // FIX THIS
    }
  }
}