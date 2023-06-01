using Employee;

namespace Employee;
internal class Program {

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите номер задания:");
        EmployeeBock employeeBock = new EmployeeBock();
        int choice = Int32.Parse(Console.ReadLine());
        switch (choice)
        {  
            case 1:
                employeeBock.EmployeeInfo();
                break;
            case 2:
                employeeBock.SalarySum();
                break;
            case 3:
                employeeBock.EmployeerMinSalary();
                break;
            case 4:
                employeeBock.EmployeerMaxSalary();
                break;
            case 5:
                employeeBock.SalaryAverage();
                break;
            case 6:
               employeeBock.EmployeesFIO();
                break;
            case 7:
                employeeBock.SalaryIndex();
                break;
            case 8:
                employeeBock.MinSalaryDeparment();
                break;
            case 9:
                employeeBock.MaxSalaryDepartment();
                break;
            case 10:
                employeeBock.AverageSalaryDepartment();
                break;
            case 11:
                employeeBock.IndexSalaryDepartment();
                break;
            case 12:
                employeeBock.EmployeesDepartmentINFO();
                break;
            case 13:
                employeeBock.SalaryLessThanNumber();
                break;
            case 14:
                employeeBock.SalaryMoreThanNumber();
                break; 
            case 15:
                employeeBock.NewEmployee();
                break;    
            case 16:
                employeeBock.DeleteEmployee();
                break;
            case 17: 
                employeeBock.NewSalaryAndDepartment();
                break;
            case 18:
                employeeBock.EmployeesInDepartments();
                break;
        }
    }
}