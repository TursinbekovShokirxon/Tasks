using ADO.NET_LESSON_1.Lesson1.Project.Connection;
using ADO.NET_LESSON_1.Lesson1.Project.Models;
using ADO.NET_LESSON_1.Lesson1.Project.Services.Interface.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ADO.NET_LESSON_1.Lesson1.Project.Services.Classes
{


    internal class CrudServiseForCustomer : CrudCustomerInterface
    {
        public void Create()
        {
            Customer customer = new Customer();
            customer=AllBuilders.ServiceForRead.Read(customer);
            string insert = $"insert into customer(customerfirstname,customerlastname,age,email) values('{customer.FirstName}','{customer.LastName}',{customer.Age},'{customer.Email}')";
            int effect = AllBuilders.managerForConnecting.Connecting(insert);
            AllBuilders.effectedRowsAllOperation.Effect(effect);
        }
        public void Delete()
        {
            List<Customer> customers = (List<Customer>)GetAll();
            if (customers.Count()>0)
            {
                ForEach.ForEachForCustomer();
                Console.Write("Enter customer_id which one you want delete :");
                int id = int.Parse(Console.ReadLine()??"");
                string delete = $"delete from customer where customer_id={id}";
                int effect = AllBuilders.managerForConnecting.Connecting(delete);
                AllBuilders.effectedRowsAllOperation.Effect(effect);
            }
            else  Console.WriteLine("Nothing for deleting!!!"); 
    }
        public IEnumerable<Customer> GetAll()
        {
            Customer task = new Customer();
            IList<Customer> _customerList = new List<Customer>() ;
            _customerList = (IList<Customer>)AllBuilders.managerForConnecting.Connecting(task);
            return _customerList;
        }
        public void Truncate()
        {
            string? Command = @"Truncate customer";
            Command=AllBuilders.selectOperation.SelectInTruncate(Command);
            int effectRofsInsert = AllBuilders.managerForConnecting.Connecting(Command);
            AllBuilders.effectedRowsAllOperation.Effect(effectRofsInsert);
        }
        public void Update()
        {
            List<Customer> customers = (List<Customer>)GetAll();
            if (customers.Count() > 0)
            {
                ForEach.ForEachForCustomer();
                Console.Write("Enter customer_id which one you want update :");
                int id = int.Parse(Console.ReadLine() ?? "");
                Customer customer = new();
                customer=   AllBuilders.ServiceForRead.Read(customer);
                string update = $"update customer set customerfirstname='{customer.FirstName}',customerlastname='{customer.LastName}',age={customer.Age},email='{customer.Email}' where customer_id={id}";
                int effect = AllBuilders.managerForConnecting.Connecting(update);
                AllBuilders.effectedRowsAllOperation.Effect(effect);
            }
            else  Console.WriteLine("Nothing for updating!!!"); 
        }
    }
}
