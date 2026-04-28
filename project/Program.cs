using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();

var allOrders = new List<Order>();

app.MapGet("/", (HttpContext context) => context.Response.Redirect("/index.html"));
app.MapGet("/menu", (HttpContext context) => context.Response.Redirect("/menu.html"));
app.MapGet("/owner", (HttpContext context) => context.Response.Redirect("/owner.html"));

app.MapPost("/saveCart", ([FromBody] SaveCartRequest request) =>
{
    var order = new Order
    {
        Id = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
        Items = request.Cart,
        Total = request.Total,
        Time = DateTime.Now.ToString("g")
    };
    allOrders.Add(order);
    return Results.Ok(new { message = "Order placed successfully!", orderId = order.Id });
});

app.MapGet("/getOrders", () =>
{
    return Results.Ok(allOrders);
});

app.Run();

public class SaveCartRequest
{
    public string[] Cart { get; set; } = Array.Empty<string>();
    public decimal Total { get; set; }
}

public class Order
{
    public long Id { get; set; }
    public string[] Items { get; set; } = Array.Empty<string>();
    public decimal Total { get; set; }
    public string Time { get; set; } = string.Empty;
}
