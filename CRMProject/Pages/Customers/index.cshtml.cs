using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MySqlConnector;

namespace CRMProject.Pages.Customers
{
    public class index : PageModel
    {
        
        public List<CustomerInfo> listCustomers { get; set; } = [];
        public void OnGet()
        {
       
           try{ 
            using (var connection = new MySqlConnector.MySqlConnection
        ("Server=localhost;Port=3306;Database=dkte1;Uid=root;Pwd=manager;")) 
        {
             connection.Open(); 
             string sql = "SELECT * FROM customers";
             var command = new MySqlConnector.MySqlCommand(sql, connection);
             {
                using (var reader = command.ExecuteReader()) 
                {
                 while (reader.Read()) 
                 { 
                    listCustomers.Add(new CustomerInfo 
                    { 
                        Id = reader.GetInt32(0), 
                        Name = reader.GetString(1), 
                        Email = reader.GetString(2), 
                        Phone = reader.GetString(3) 
                    }); 
                } 
            } 
        }
        }
        }
        catch (Exception ex) 
        {
             Console.WriteLine($"Error retrieving customers: {ex.Message}");
        }


        }
    }
    public class CustomerInfo 
    { 
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string Email { get; set; } 
        public string Phone { get; set; } 
    }

}