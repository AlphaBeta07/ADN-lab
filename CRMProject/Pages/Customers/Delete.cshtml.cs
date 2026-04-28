using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySqlConnector;

namespace CRMProject.Pages.Customers
{
    public class Delete : PageModel
    {
        [BindProperty]
        public int CustomerId { get; set; }

        public void OnGet(int id)
        {
            CustomerId = id;
        }

        public IActionResult OnPost()
        {
            try
            {
                using (var connection = new MySqlConnection(
                    "Server=localhost;Port=3306;Database=dkte1;Uid=root;Pwd=manager;"))
                {
                    connection.Open();

                    var command = new MySqlCommand(
                        "DELETE FROM customers WHERE id = @id",
                        connection);

                    command.Parameters.AddWithValue("@id", CustomerId);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return RedirectToPage("/Customers/Index");
        }
    }
}