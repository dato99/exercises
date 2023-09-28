using davaleba_7;

var builder = WebApplication.CreateBuilder(args);

var repository = new TeacherRepository();
var teachers = repository.GetAllTeachersByStudent("George");

Console.WriteLine("Teachers who teach a student named 'George':");
foreach (var teacher in teachers)
{
    Console.WriteLine($"{teacher.Name} {teacher.Surname}");
}

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
