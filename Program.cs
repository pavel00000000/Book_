using Book;  // ����������� ������������ ���� � ��������

var builder = WebApplication.CreateBuilder(args);

// ���������� ������� � DI ���������
builder.Services.AddSingleton<INewService, NewService>();

// ���������� �������� � ���������
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ��������� HTTP-��������
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();  // �������� ������������

app.Run();
