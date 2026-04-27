using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();

var app = builder.Build();
app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.UseDefaultFiles();
app.UseStaticFiles();

var students = new List<Student>();

app.MapGet("/api/students", () => Results.Ok(students));

app.MapGet("/api/students/{id:int}", (int id) =>
{
    var student = students.Find(s => s.Id == id);
    return student is not null ? Results.Ok(student) : Results.NotFound(new { message = "Student not found." });
});

app.MapPost("/api/students", async (HttpRequest request) =>
{
    var student = await request.ReadFromJsonAsync<Student>();
    if (student is null)
    {
        return Results.BadRequest(new { message = "Invalid student data." });
    }

    if (students.Any(s => s.Id == student.Id))
    {
        return Results.Conflict(new { message = "A student with the same ID already exists." });
    }

    students.Add(student);
    return Results.Created($"/api/students/{student.Id}", student);
});

app.MapPut("/api/students/{id:int}", async (int id, HttpRequest request) =>
{
    var update = await request.ReadFromJsonAsync<Student>();
    if (update is null)
    {
        return Results.BadRequest(new { message = "Invalid student data." });
    }

    var student = students.Find(s => s.Id == id);
    if (student is null)
    {
        return Results.NotFound(new { message = "Student not found." });
    }

    student.Name = update.Name;
    student.Age = update.Age;
    student.Course = update.Course;

    return Results.Ok(student);
});

app.MapDelete("/api/students/{id:int}", (int id) =>
{
    var student = students.Find(s => s.Id == id);
    if (student is null)
    {
        return Results.NotFound(new { message = "Student not found." });
    }

    students.Remove(student);
    return Results.NoContent();
});

app.MapFallbackToFile("index.html");

app.Run();
