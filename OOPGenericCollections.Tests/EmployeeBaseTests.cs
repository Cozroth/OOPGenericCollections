using NUnit.Framework;
using OOPGenericCollections.App.EmployeeObj;
using OOPGenericCollections.ValidationUtility;

namespace OOPGenericCollections.Tests
{
  public class TestEmployeeData
  {
    public string Name1 { get; } = "Name1";
    public string Name2 { get; } = "Name2";
    public string Name3 { get; } = "Name3";

    public string Gender1 { get; } = "Male";
    public string Gender2 { get; } = "Female";
    public string Gender3 { get; } = "Male";
    public int Id1 { get; } = 100;
    public int Id2 { get; } = 101;
    public int Id3 { get; } = 102;
    public double Salary1 { get; } = 2500;
    public double Salary2 { get; } = 2000;
    public double Salary3 { get; } = 1500;
    public Employee Employee1 { get; }
    public Employee Employee2 { get; }
    public Employee Employee3 { get; }

    public TestEmployeeData()
    {
      Employee1 = new Employee(Name1, Gender1, Id1, Salary1);
      Employee2 = new Employee(Name2, Gender2, Id2, Salary2);
      Employee3 = new Employee(Name3, Gender3, Id3, Salary3);
    }
  }




  [TestFixture]
  public class EmployeeBaseTests
  {
    [Test]
    public void CreateEmployee_Success()
    {
      TestEmployeeData expected = new();

      var employee = new Employee(expected.Name1, expected.Gender1, expected.Id1, expected.Salary1);


      Assert.AreEqual($"{expected.Id1} - {expected.Name1} - {expected.Gender1} - {expected.Salary1}", employee.ToString());
    }
  }

  [TestFixture]
  public class ValidationUtilityTests
  {
    [Test]
    public void AddEmployeesToList_Success()
    {
      TestEmployeeData expected = new();
      var actualEmployee1 = new Employee(expected.Name1, expected.Gender1, expected.Id1, expected.Salary1);
      var actualEmployee2 = new Employee(expected.Name2, expected.Gender2, expected.Id2, expected.Salary2);
      var actualEmployee3 = new Employee(expected.Name3, expected.Gender3, expected.Id3, expected.Salary3);

      Employee[] employeeArray_Actual = new Employee[3] { actualEmployee1, actualEmployee2, actualEmployee3 };

      List<Employee> employeeList_Actual = new();

      ListValidationHelper.AddObjectsToList(employeeArray_Actual, employeeList_Actual);

      List<Employee> employeeList_Expected = new()
      {
        expected.Employee1,
        expected.Employee2,
        expected.Employee3
      };

      for (int i = 0; i < employeeList_Expected.Count; i++)
      {
        var expectedEmployee = employeeList_Expected[i];
        var actualEmployee = employeeList_Actual[i];

        Assert.AreEqual(expectedEmployee.Id, actualEmployee.Id);
        Assert.AreEqual(expectedEmployee.Name, actualEmployee.Name);
        Assert.AreEqual(expectedEmployee.Gender, actualEmployee.Gender);
        Assert.AreEqual(expectedEmployee.Salary, actualEmployee.Salary);
      }
    }
  }
}