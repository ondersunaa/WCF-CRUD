Wcf servis ile MSSQL Server üzerinden Crud işlemlerini gerçekleştirdim. 

Methodlar

        List<Employee> GetAllEmployees(); 
        
        Employee GetEmployeeById(int id);
    
        void UpdateEmployee(Employee model);
     
        void DeleteEmployee(int id);
       
        void InsertEmployee(Employee model);

Projemde Ado.net kullanılmıştır. Host işlemi için consolApp kullanılmıştır ve Client tarafta ise .net core 3.1 ile WebApp kullanılmıştır.