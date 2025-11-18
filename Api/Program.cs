using Api.Storage;

var builder = WebApplication.CreateBuilder(args);

//добавл€ет сервис дл€ работы с контролерами
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

//единственный экземпл€р на врем€ работы 
builder.Services.AddSingleton<DataContext>();
builder.Services.AddSingleton<ContactStorage>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.Run();

