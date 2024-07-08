using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{

    //public class Employee
    //{

    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int SecurityLevel { get; set; }
    //    public decimal Salary { get; set; }
    //    public DateTime HireDate { get; set; }
    //    public string Gender { get; set; }



    //    public Employee(int id, string name, int securityLevel, decimal salary, DateTime hireDate, string gender)
    //    {
    //        Id = id;
    //        Name = name;
    //        SecurityLevel = securityLevel;
    //        Salary = salary;
    //        HireDate = hireDate;
    //        Gender = gender;
    //    }

    //    public void DisplayEmployeeDetails()
    //    {
    //        Console.WriteLine("Employee Details:");
    //        Console.WriteLine($"ID: {Id}");
    //        Console.WriteLine($"Name: {Name}");
    //        Console.WriteLine($"Security Level: {SecurityLevel}");
    //        Console.WriteLine($"Salary: {Salary:C}");
    //        Console.WriteLine($"Hire Date: {HireDate.ToShortDateString()}");
    //        Console.WriteLine($"Gender: {Gender}");
    //    }
    //}
    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    //public class HireDate
    //{
    //    // Properties
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }

    //    // Constructor
    //    public HireDate(int day, int month, int year)
    //    {
    //        if (IsValidDate(day, month, year))
    //        {
    //            Day = day;
    //            Month = month;
    //            Year = year;
    //        }
    //        else
    //        {
    //            throw new ArgumentException("Invalid date");
    //        }
    //    }

    //    // Method to validate date
    //    private bool IsValidDate(int day, int month, int year)
    //    {
    //        // Simple validation for month and day ranges
    //        if (month < 1 || month > 12 || day < 1 || day > 31)
    //        {
    //            return false;
    //        }

    //        // Check for months with 30 days
    //        if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
    //        {
    //            return false;
    //        }

    //        // Check for February
    //        if (month == 2)
    //        {
    //            if (IsLeapYear(year) && day > 29)
    //            {
    //                return false;
    //            }
    //            else if (!IsLeapYear(year) && day > 28)
    //            {
    //                return false;
    //            }
    //        }

    //        return true;
    //    }

    //    // Method to check if a year is a leap year
    //    private bool IsLeapYear(int year)
    //    {
    //        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    //    }

    //    // Method to display the date as a string
    //    public override string ToString()
    //    {
    //        return $"{Day:D2}/{Month:D2}/{Year}";
    //    }
    //}

    //public class Employee
    //{
    //    // Properties
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int SecurityLevel { get; set; }
    //    public decimal Salary { get; set; }
    //    public HireDate HireDate { get; set; }
    //    public string Gender { get; set; }

    //    // Constructor
    //    public Employee(int id, string name, int securityLevel, decimal salary, HireDate hireDate, string gender)
    //    {
    //        Id = id;
    //        Name = name;
    //        SecurityLevel = securityLevel;
    //        Salary = salary;
    //        HireDate = hireDate;
    //        Gender = gender;
    //    }

    //    // Method to display employee details
    //    public void DisplayEmployeeDetails()
    //    {
    //        Console.WriteLine("Employee Details:");
    //        Console.WriteLine($"ID: {Id}");
    //        Console.WriteLine($"Name: {Name}");
    //        Console.WriteLine($"Security Level: {SecurityLevel}");
    //        Console.WriteLine($"Salary: {Salary:C}");
    //        Console.WriteLine($"Hire Date: {HireDate}");
    //        Console.WriteLine($"Gender: {Gender}");
    //    }
    //}
    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    /// 

    //public class HireDate
    //{
    //    // Properties
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }

    //    // Constructor
    //    public HireDate(int day, int month, int year)
    //    {
    //        if (IsValidDate(day, month, year))
    //        {
    //            Day = day;
    //            Month = month;
    //            Year = year;
    //        }
    //        else
    //        {
    //            throw new ArgumentException("Invalid date");
    //        }
    //    }

    //    // Method to validate date
    //    private bool IsValidDate(int day, int month, int year)
    //    {
    //        // Simple validation for month and day ranges
    //        if (month < 1 || month > 12 || day < 1 || day > 31)
    //        {
    //            return false;
    //        }

    //        // Check for months with 30 days
    //        if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
    //        {
    //            return false;
    //        }

    //        // Check for February
    //        if (month == 2)
    //        {
    //            if (IsLeapYear(year) && day > 29)
    //            {
    //                return false;
    //            }
    //            else if (!IsLeapYear(year) && day > 28)
    //            {
    //                return false;
    //            }
    //        }

    //        return true;
    //    }

    //    // Method to check if a year is a leap year
    //    private bool IsLeapYear(int year)
    //    {
    //        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    //    }

    //    // Method to display the date as a string
    //    public override string ToString()
    //    {
    //        return $"{Day:D2}/{Month:D2}/{Year}";
    //    }
    //}

    //public class Employee
    //{
    //    // Properties
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int SecurityLevel { get; set; }
    //    public decimal Salary { get; set; }
    //    public HireDate HireDate { get; set; }
    //    private string gender;
    //    public string Gender
    //    {
    //        get { return gender; }
    //        set
    //        {
    //            if (value == "M" || value == "F")
    //            {
    //                gender = value;
    //            }
    //            else
    //            {
    //                throw new ArgumentException("Gender must be 'M' or 'F'");
    //            }
    //        }
    //    }

    //    // Constructor
    //    public Employee(int id, string name, int securityLevel, decimal salary, HireDate hireDate, string gender)
    //    {
    //        Id = id;
    //        Name = name;
    //        SecurityLevel = securityLevel;
    //        Salary = salary;
    //        HireDate = hireDate;
    //        Gender = gender;  // This will trigger the validation
    //    }

    //    // Method to display employee details
    //    public void DisplayEmployeeDetails()
    //    {
    //        Console.WriteLine("Employee Details:");
    //        Console.WriteLine($"ID: {Id}");
    //        Console.WriteLine($"Name: {Name}");
    //        Console.WriteLine($"Security Level: {SecurityLevel}");
    //        Console.WriteLine($"Salary: {Salary:C}");
    //        Console.WriteLine($"Hire Date: {HireDate}");
    //        Console.WriteLine($"Gender: {Gender}");
    //    }
    //}
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    /// // Enum to represent security privileges
    //public enum SecurityLevel
    //{
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA
    //}

    //public class HireDate
    //{
    //    // Properties
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }

    //    // Constructor
    //    public HireDate(int day, int month, int year)
    //    {
    //        if (IsValidDate(day, month, year))
    //        {
    //            Day = day;
    //            Month = month;
    //            Year = year;
    //        }
    //        else
    //        {
    //            throw new ArgumentException("Invalid date");
    //        }
    //    }

    //    // Method to validate date
    //    private bool IsValidDate(int day, int month, int year)
    //    {
    //        // Simple validation for month and day ranges
    //        if (month < 1 || month > 12 || day < 1 || day > 31)
    //        {
    //            return false;
    //        }

    //        // Check for months with 30 days
    //        if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
    //        {
    //            return false;
    //        }

    //        // Check for February
    //        if (month == 2)
    //        {
    //            if (IsLeapYear(year) && day > 29)
    //            {
    //                return false;
    //            }
    //            else if (!IsLeapYear(year) && day > 28)
    //            {
    //                return false;
    //            }
    //        }

    //        return true;
    //    }

    //    // Method to check if a year is a leap year
    //    private bool IsLeapYear(int year)
    //    {
    //        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    //    }

    //    // Method to display the date as a string
    //    public override string ToString()
    //    {
    //        return $"{Day:D2}/{Month:D2}/{Year}";
    //    }
    //}

    //public class Employee
    //{
    //    // Properties
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public SecurityLevel SecurityLevel { get; set; }
    //    public decimal Salary { get; set; }
    //    public HireDate HireDate { get; set; }
    //    private string gender;
    //    public string Gender
    //    {
    //        get { return gender; }
    //        set
    //        {
    //            if (value == "M" || value == "F")
    //            {
    //                gender = value;
    //            }
    //            else
    //            {
    //                throw new ArgumentException("Gender must be 'M' or 'F'");
    //            }
    //        }
    //    }

    //    // Constructor
    //    public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HireDate hireDate, string gender)
    //    {
    //        Id = id;
    //        Name = name;
    //        SecurityLevel = securityLevel;
    //        Salary = salary;
    //        HireDate = hireDate;
    //        Gender = gender;  // This will trigger the validation
    //    }

    //    // Method to display employee details
    //    public void DisplayEmployeeDetails()
    //    {
    //        Console.WriteLine("Employee Details:");
    //        Console.WriteLine($"ID: {Id}");
    //        Console.WriteLine($"Name: {Name}");
    //        Console.WriteLine($"Security Level: {SecurityLevel}");
    //        Console.WriteLine($"Salary: {Salary:C}");
    //        Console.WriteLine($"Hire Date: {HireDate}");
    //        Console.WriteLine($"Gender: {Gender}");
    //    }
    //}

    //////////////////////////////////////////////////////////////////////////////
    ///
    //public enum SecurityLevel
    //{
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA // Assuming DBA has full permissions
    //}

    //public class HireDate
    //{
    //    // Properties
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }

    //    // Constructor
    //    public HireDate(int day, int month, int year)
    //    {
    //        if (IsValidDate(day, month, year))
    //        {
    //            Day = day;
    //            Month = month;
    //            Year = year;
    //        }
    //        else
    //        {
    //            throw new ArgumentException("Invalid date");
    //        }
    //    }

    //    // Method to validate date
    //    private bool IsValidDate(int day, int month, int year)
    //    {
    //        // Simple validation for month and day ranges
    //        if (month < 1 || month > 12 || day < 1 || day > 31)
    //        {
    //            return false;
    //        }

    //        // Check for months with 30 days
    //        if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
    //        {
    //            return false;
    //        }

    //        // Check for February
    //        if (month == 2)
    //        {
    //            if (IsLeapYear(year) && day > 29)
    //            {
    //                return false;
    //            }
    //            else if (!IsLeapYear(year) && day > 28)
    //            {
    //                return false;
    //            }
    //        }

    //        return true;
    //    }

    //    // Method to check if a year is a leap year
    //    private bool IsLeapYear(int year)
    //    {
    //        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    //    }

    //    // Method to display the date as a string
    //    public override string ToString()
    //    {
    //        return $"{Day:D2}/{Month:D2}/{Year}";
    //    }
    //}

    //public class Employee
    //{
    //    // Properties
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public SecurityLevel SecurityLevel { get; set; }
    //    public decimal Salary { get; set; }
    //    public HireDate HireDate { get; set; }
    //    private string gender;
    //    public string Gender
    //    {
    //        get { return gender; }
    //        set
    //        {
    //            if (value == "M" || value == "F")
    //            {
    //                gender = value;
    //            }
    //            else
    //            {
    //                throw new ArgumentException("Gender must be 'M' or 'F'");
    //            }
    //        }
    //    }

    //    // Constructor
    //    public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HireDate hireDate, string gender)
    //    {
    //        Id = id;
    //        Name = name;
    //        SecurityLevel = securityLevel;
    //        Salary = salary;
    //        HireDate = hireDate;
    //        Gender = gender;  // This will trigger the validation
    //    }

    //    // Override ToString method
    //    public override string ToString()
    //    {
    //        return String.Format(
    //            "Employee Details:\nID: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3:C}\nHire Date: {4}\nGender: {5}",
    //            Id, Name, SecurityLevel, Salary, HireDate, Gender
    //        );
    //    }
    //}

    //////////////////////////////////////////////////////////////////////////////////////////////
    //public enum SecurityLevel
    //{
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA // Assuming DBA has full permissions
    //}

    //public class HireDate : IComparable<HireDate>
    //{
    //    // Properties
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }

    //    // Constructor
    //    public HireDate(int day, int month, int year)
    //    {
    //        if (IsValidDate(day, month, year))
    //        {
    //            Day = day;
    //            Month = month;
    //            Year = year;
    //        }
    //        else
    //        {
    //            throw new ArgumentException("Invalid date");
    //        }
    //    }

    //    // Method to validate date
    //    private bool IsValidDate(int day, int month, int year)
    //    {
    //        // Simple validation for month and day ranges
    //        if (month < 1 || month > 12 || day < 1 || day > 31)
    //        {
    //            return false;
    //        }

    //        // Check for months with 30 days
    //        if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
    //        {
    //            return false;
    //        }

    //        // Check for February
    //        if (month == 2)
    //        {
    //            if (IsLeapYear(year) && day > 29)
    //            {
    //                return false;
    //            }
    //            else if (!IsLeapYear(year) && day > 28)
    //            {
    //                return false;
    //            }
    //        }

    //        return true;
    //    }

    //    // Method to check if a year is a leap year
    //    private bool IsLeapYear(int year)
    //    {
    //        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    //    }

    //    // Method to display the date as a string
    //    public override string ToString()
    //    {
    //        return $"{Day:D2}/{Month:D2}/{Year}";
    //    }

    //    // Implement IComparable<HireDate> to enable sorting by date
    //    public int CompareTo(HireDate other)
    //    {
    //        if (other == null) return 1;

    //        int yearComparison = this.Year.CompareTo(other.Year);
    //        if (yearComparison != 0) return yearComparison;

    //        int monthComparison = this.Month.CompareTo(other.Month);
    //        if (monthComparison != 0) return monthComparison;

    //        return this.Day.CompareTo(other.Day);
    //    }
    //}

    //public class Employee
    //{
    //    // Properties
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public SecurityLevel SecurityLevel { get; set; }
    //    public decimal Salary { get; set; }
    //    public HireDate HireDate { get; set; }
    //    private string gender;
    //    public string Gender
    //    {
    //        get { return gender; }
    //        set
    //        {
    //            if (value == "M" || value == "F")
    //            {
    //                gender = value;
    //            }
    //            else
    //            {
    //                throw new ArgumentException("Gender must be 'M' or 'F'");
    //            }
    //        }
    //    }

    //    // Constructor
    //    public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HireDate hireDate, string gender)
    //    {
    //        Id = id;
    //        Name = name;
    //        SecurityLevel = securityLevel;
    //        Salary = salary;
    //        HireDate = hireDate;
    //        Gender = gender;  // This will trigger the validation
    //    }

    //    // Override ToString method
    //    public override string ToString()
    //    {
    //        return String.Format(
    //            "Employee Details:\nID: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3:C}\nHire Date: {4}\nGender: {5}",
    //            Id, Name, SecurityLevel, Salary, HireDate, Gender
    //        );
    //    }
    //}

    internal class Program
    {
        //private static int boxingCounter = 0;
        //private static int unboxingCounter = 0;
        static void Main(string[] args)
        {
            //Employee emp = new Employee(1, "mahmoud elesawy", 15, 4000m, new DateTime(2024, 7, 8), "Male");


            //emp.DisplayEmployeeDetails();
            //////////////////////////////////////////////////////////////////////////////////////
            //HireDate hireDate = new HireDate(15, 1, 2020);
            //Employee emp = new Employee(1, "eslam ", 4, 3000m, hireDate, "Male");
            //emp.DisplayEmployeeDetails();
            //////////////////////////////////////////////////////////////////////////////////////
            ///
            //try
            //{
            //    // Creating an instance of HireDate
            //    HireDate hireDate = new HireDate(15, 1, 2020);

            //    // Creating an instance of Employee with valid gender
            //    Employee emp1 = new Employee(1, " mahmoud elesawy", 5, 4000m, hireDate, "M");
            //    emp1.DisplayEmployeeDetails();

            //    // Creating an instance of Employee with invalid gender
            //    Employee emp2 = new Employee(2, "eslam", 4, 3000m, hireDate, "X");
            //    emp2.DisplayEmployeeDetails();
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //////////////////////////////////////////////////////////////////////////////////////



            //try
            //{
            //    // Creating an instance of HireDate
            //    HireDate hireDate = new HireDate(15, 1, 2020);

            //    // Creating an instance of Employee with valid gender and security level
            //    Employee emp1 = new Employee(1, "John Doe", SecurityLevel.Developer, 50000m, hireDate, "M");
            //    emp1.DisplayEmployeeDetails();

            //    // Creating an instance of Employee with invalid gender
            //    Employee emp2 = new Employee(2, "Jane Doe", SecurityLevel.Secretary, 45000m, hireDate, "X");
            //    emp2.DisplayEmployeeDetails();
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //////////////////////////////////////////////////////////////////////////////////////
            //try
            //{
            //    // Creating an instance of HireDate
            //    HireDate hireDate = new HireDate(15, 1, 2020);

            //    // Creating an instance of Employee with valid gender and security level
            //    Employee emp1 = new Employee(1, "John Doe", SecurityLevel.Developer, 50000m, hireDate, "M");
            //    Console.WriteLine(emp1.ToString());

            //    // Creating an instance of Employee with invalid gender
            //    Employee emp2 = new Employee(2, "Jane Doe", SecurityLevel.Secretary, 45000m, hireDate, "X");
            //    Console.WriteLine(emp2.ToString());
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            ///////////////////////////////////////////////////////////////////////////////////////
            //try
            //{
            //    // Creating instances of HireDate
            //    HireDate hireDate1 = new HireDate(15, 1, 2020);
            //    HireDate hireDate2 = new HireDate(10, 2, 2021);
            //    HireDate hireDate3 = new HireDate(5, 3, 2022);

            //    // Creating instances of Employee with different security levels
            //    Employee emp1 = new Employee(1, "John Doe", SecurityLevel.DBA, 75000m, hireDate1, "M");
            //    Employee emp2 = new Employee(2, "Alice Smith", SecurityLevel.Guest, 30000m, hireDate2, "F");
            //    Employee emp3 = new Employee(3, "Bob Johnson", SecurityLevel.DBA, 80000m, hireDate3, "M"); // Assuming DBA has full permissions

            //    // Creating an array of Employees
            //    Employee[] EmpArr = new Employee[] { emp1, emp2, emp3 };

            //    // Displaying employee details
            //    foreach (var emp in EmpArr)
            //    {
            //        Console.WriteLine(emp.ToString());
            //        Console.WriteLine();
            //    }
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //////////////////////////////////////////////////////////////////////////////

            //try
            //{
            //    // Creating instances of HireDate
            //    HireDate hireDate1 = new HireDate(15, 1, 2020);
            //    HireDate hireDate2 = new HireDate(10, 2, 2021);
            //    HireDate hireDate3 = new HireDate(5, 3, 2022);

            //    // Creating instances of Employee with different security levels
            //    Employee emp1 = new Employee(1, "John Doe", SecurityLevel.DBA, 75000m, hireDate1, "M");
            //    Employee emp2 = new Employee(2, "Alice Smith", SecurityLevel.Guest, 30000m, hireDate2, "F");
            //    Employee emp3 = new Employee(3, "Bob Johnson", SecurityLevel.DBA, 80000m, hireDate3, "M"); // Assuming DBA has full permissions

            //    // Creating an array of Employees
            //    Employee[] EmpArr = new Employee[] { emp1, emp2, emp3 };

            //    // Sorting employees based on their hire date
            //    Array.Sort(EmpArr, (x, y) =>
            //    {
            //        // Count hypothetical boxing/unboxing if x and y were value types
            //        BoxingUnboxingExample(x.HireDate);
            //        BoxingUnboxingExample(y.HireDate);

            //        return x.HireDate.CompareTo(y.HireDate);
            //    });

            //    // Displaying sorted employee details
            //    foreach (var emp in EmpArr)
            //    {
            //        Console.WriteLine(emp.ToString());
            //        Console.WriteLine();
            //    }

            //    // Display boxing and unboxing counts
            //    Console.WriteLine($"Boxing operations: {boxingCounter}");
            //    Console.WriteLine($"Unboxing operations: {unboxingCounter}");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }

        // Method to simulate boxing/unboxing example
        //static void BoxingUnboxingExample(HireDate date)
        //{
        //    // Boxing
        //    object boxedDate = date;
        //    boxingCounter++;

        //    // Unboxing
        //    HireDate unboxedDate = (HireDate)boxedDate;
        //    unboxingCounter++;
        //}
    }
}