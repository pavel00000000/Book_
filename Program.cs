using Book;  // Подключение пространства имен с сервисом

var builder = WebApplication.CreateBuilder(args);

// Добавление сервиса в DI контейнер
builder.Services.AddSingleton<INewService, NewService>();

// Добавление сервисов в контейнер
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Настройка HTTP-запросов
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();  // Привязка контроллеров

app.Run();
