using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MySqlConnector;

namespace CRMProject.Pages.Customers
{
    public class Edit : PageModel
    {
        private readonly ILogger<Edit> _logger;

        public Edit(ILogger<Edit> logger)
        {
            _logger = logger;
        }

        // Properties

        [BindProperty]
        public int CustId { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Enter the name")]
        public string CustName { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Enter the email")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string CustEmail { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Enter the phone number")]
        public string CustPhone { get; set; } = "";

        public string ErrorMessage { get; set; } = "";

        // ================== GET ==================

        public IActionResult OnGet(int id)
        {
            CustId = id;

            try
            {
                using (var connection = new MySqlConnection(
                    "Server=localhost;Port=3306;Database=dkte1;Uid=root;Pwd=manager;"))
                {
                    connection.Open();

                    var command = new MySqlCommand(
                        "SELECT name, email, phone FROM customers WHERE id = @id",
                        connection);

                    command.Parameters.AddWithValue("@id", CustId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CustName = reader.GetString(0);
                            CustEmail = reader.GetString(1);
                            CustPhone = reader.GetString(2);
                        }
                        else
                        {
                            ErrorMessage = "Customer not found.";
                            return RedirectToPage("/Customers/Index");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return Page();
            }

            return Page();
        }

        // ================== POST ==================

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            try
            {
                using (var connection = new MySqlConnection(
                    "Server=localhost;Port=3306;Database=dkte1;Uid=root;Pwd=manager;"))
                {
                    connection.Open();

                    var command = new MySqlCommand(
                        "UPDATE customers SET name=@name, email=@email, phone=@phone WHERE id=@id",
                        connection);

                    command.Parameters.AddWithValue("@name", CustName);
                    command.Parameters.AddWithValue("@email", CustEmail);
                    command.Parameters.AddWithValue("@phone", CustPhone);
                    command.Parameters.AddWithValue("@id", CustId);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return Page();
            }

            return RedirectToPage("/Customers/Index");
        }
    }
}