// Tobias Skog - .NET23
namespace OOPGenericCollections
{
    // New sepparate static class LogicHandler that is in place to help the user
    // with repeating tasks and make the Program.cs look less clutered
    // It also introduces some error handling logic to not crash the software
    internal static class LogicHandler
    {
        // public static method with no return that takes an array of Employee objects and a Stack of Employee objects
        // it then loops thru the array of employees and adds each and everyone one of the objects to the Stack
        public static void AddObjectsToStack(Employee[] employees, Stack<Employee> stack)
        {
            // for loop for the length of the employees array
            for (int i = 0; i < employees.Length; i++)
            {
                // adding current index employee to the stack
                stack.Push(employees[i]);
            }
        }

        // public static method with no return that takes an array of Employee objects and a List of Employee objects
        // it then loops thru the array of employees and adds each and everyone one of the objects to the List
        public static void AddObjectsToList(Employee[] employees, List<Employee> list)
        {
            // for loop for the length of the employees array
            for (int i = 0; i < employees.Length; i++)
            {
                // adding current index employee to the list
                list.Add(employees[i]);
            }
        }

        // public static method with no return that takes a List of Employee objects and a string of the object you want to find
        // We apply the following logic
        // IF the list is NOT empty
        // AND
        // IF an object with the Gender attribute matching the findItem string exists
        // After passing the logic we create a new var e, we are using a var to implicitly assign a datatype 
        // based on the right side of the assignment instead of going thru and creating a new Employee object
        // We add the result of the List.Find() method to our newly created var e
        // Writes to the console the ID, Name, Gender and Salary in the newly specified format
        // described in the assignment
        // ELSE the list was empty OR the findItem did NOT exist in our list
        // Writes to the console a error message that we did not find the item we were looking for

        public static void FindFirstGenderInList(List<Employee> list, string findItem)
        {
            if (list.Count > 0 && list.Exists(employee => employee.Gender == findItem))
            {
                var e = list.Find(employee => employee.Gender == findItem);
                Console.WriteLine($"ID = {e.Id}, NAame = {e.Name}, Gender = {e.Gender}, Salary = {e.Salary}");

            }
            else
            {
                Console.WriteLine($"List did not contain \"{findItem}\".");
            }
        }

        // public static method with no return that takes a List of Employee objects and a string of the object you want to find
        // We apply the following logic
        // IF the list is NOT empty
        // AND
        // IF an object with the Gender attribute matching the findItem string exists
        // After passing the logic we create a new List<Employee> results that holds all
        // the Employee objects we find wich have the Gender with the specified findItem value
        // Foreach loop of the results list to be able to access every Employee object we found in our search
        // Writes to the console the ID, Name, Gender and Salary in the newly specified format
        // described in the assignment
        // ELSE the list was empty OR the findItem did NOT exist in our list
        // Writes to the console a error message that we did not find the item we were looking for
        public static void FindAllGenderInList(List<Employee> list, string findItem)
        {
            if (list.Count > 0 && list.Exists(employee => employee.Gender == findItem))
            {
                List<Employee> results = list.FindAll(e => e.Gender == findItem);
                foreach (Employee employee in results)
                {
                    Console.WriteLine($"ID = {employee.Id}, NAame = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
                }
            }
            else
            {
                Console.WriteLine($"List did not contain \"{findItem}\".");
            }
        }
    }
}
