using NorthwindService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INorthwindService" in both code and config file together.
    [ServiceContract]
    public interface INorthwindService
    {
        [OperationContract]
        List<Employee> GetAllEmployees();
        [OperationContract]
        Employee GetEmployeeById(int id);
        [OperationContract]
        void UpdateEmployee(Employee model);
        [OperationContract]
        void DeleteEmployee(int id);
        [OperationContract]
        void InsertEmployee(Employee model);
    }
}
