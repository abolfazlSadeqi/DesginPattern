using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Classes.Instance;



public class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Code { get; set; }


}

public class EmployeeCURD
{
    public string GetNameCode(Employee employee)
    {
        return employee.Name + employee.Code;
    }
}
