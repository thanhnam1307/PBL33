using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Employee
    {

        private PBL3Entities db = new PBL3Entities();
        public int LoginAs(string username, string password)
        {
            var employee = db.tb_Employee.FirstOrDefault(e => e.EmployeeID.Trim() == username && e.Password.Trim() == password);
            if (employee != null)
            {
                Console.WriteLine("User is an employee");
                return 2 ;
            }

            var customer = db.tb_Customer.FirstOrDefault(c => c.CustomerID.Trim() == username && c.Password.Trim() == password);
            if (customer != null)
            {
                Console.WriteLine("User is a customer");
                return 1;
            }

            // Kiểm tra nếu là quản trị viên
            if (username == "Admin" && password == "Abc123")
            {
                Console.WriteLine("User is an admin");
                return 3;
            }

            // Nếu không phải là nhân viên, khách hàng hoặc quản trị viên
            return 0;
        }

        public List<tb_Employee> GetAccountsFromTable(string tableName)
        {

            return db.tb_Employee.ToList();

        }
        public tb_Employee getItem(string id) { return db.tb_Employee.FirstOrDefault(x => x.EmployeeID == id); }
        public bool CheckLogin(string username, string password)
        {
            List<tb_Employee> tb_Employee = GetAccountsFromTable("tb_Employee");

            foreach (var account in tb_Employee)
            {
                if (account.EmployeeID.Trim() == username && account.Password.Trim() == password)
                {
                    return true;
                }
            }

            return false;
        }
        public bool checkExist(string username)
        {
            List<tb_Employee> tb_Employee = GetAccountsFromTable("tb_Employee");

            foreach (var account in tb_Employee)
            {
                if (account.EmployeeID.Trim() == username)
                {
                    return true;
                }
            }

            return false;
        }
        public tb_Employee AddNew(tb_Employee customer)
        {
            try
            {
                db.tb_Employee.Add(customer);
                db.SaveChanges();
                return customer;
            }
            catch (DbUpdateException ex)
            {
                // Check if there is an inner exception
                if (ex.InnerException != null)
                {
                    // Log or handle the inner exception
                    Console.WriteLine("Inner Exception Message: " + ex.InnerException.Message);
                }

                // Rethrow the original exception to preserve the stack trace
                throw;
            }

        }
        public tb_Employee Update(tb_Employee customer)
        {
            try
            {
                var _dt = db.tb_Employee.FirstOrDefault(x => x.EmployeeID == customer.EmployeeID);
                _dt.BirthDate = customer.BirthDate;
                _dt.Gender = customer.Gender;
                _dt.Name = customer.Name;
                _dt.PhoneNumber = customer.PhoneNumber;
                _dt.Password = customer.Password;
                _dt.WorkingTime = customer.WorkingTime;
                _dt.Salary = customer.Salary;
                _dt.TypeEmpID = customer.TypeEmpID;
                db.SaveChanges();

                return customer;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(string id)
        {
            try
            {
                var _dt = db.tb_Employee.FirstOrDefault(x => x.EmployeeID == id);
                db.tb_Employee.Remove(_dt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
