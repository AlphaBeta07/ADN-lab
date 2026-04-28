using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySqlConnector;

namespace CRMProject.Pages.Customers
{
    public class Create : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Enter the name")]
        public string Name { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Enter the email")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Enter the phone number")]
        public string Phone { get; set; } = "";

        public string ErrorMessage { get; set; } = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Form is Invalid");
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(
                    "Server=localhost;Port=3306;Database=dkte1;Uid=root;Pwd=manager;"))
                {
                    connection.Open();

                    var command = new MySqlCommand(
                        "INSERT INTO Customers (name, email, phone) VALUES (@CustName, @CustEmail, @CustPhone)",
                        connection);

                    command.Parameters.AddWithValue("@CustName", Name);
                    command.Parameters.AddWithValue("@CustEmail", Email);
                    command.Parameters.AddWithValue("@CustPhone", Phone);

                    int i = command.ExecuteNonQuery();
                    if(i>0)
                    {
                        Console.WriteLine("Customer added successfully.");
                        RedirectToPage("/Customer/Index");
                    }
                    else
                    {
                        Console.WriteLine("Failed to add customer.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding customer. Error: " + ex.Message);
                ErrorMessage = ex.Message;
                return;
            }

            Response.Redirect("/Customers/Index");
        }
    }
}