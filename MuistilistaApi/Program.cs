var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
});

var app = builder.Build();

app.UseCors("AllowAll");

var todoList = new List<Todo>
{
    new Todo { Id = 1, Title = "Hae maitoa", Description = "Käy kaupassa hakemassa maitoa ja leipää", Complete = false, Cancelled = false, Date = DateTime.Now.AddDays(-1) },
    new Todo { Id = 2, Title = "Korjaa polkupyörä", Description = "Tarkista jarrut ja voitele ketju", Complete = true, Cancelled = false, Date = DateTime.Now.AddDays(-3) },
    new Todo { Id = 3, Title = "Laske verot", Description = "Tee veroilmoitus ennen määräaikaa", Complete = false, Cancelled = false, Date = DateTime.Now }
};

app.MapGet("/tasks", () => todoList);

app.MapGet("/task/{id}", (int id) =>
{
    var task = todoList.FirstOrDefault(t => t.Id == id);
    return task is not null ? Results.Ok(task) : Results.NotFound("Tehtävää ei löytynyt");
});

app.Run();

public class Todo
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool Complete { get; set; }
    public bool Cancelled { get; set; }
    public DateTime Date { get; set; }
}