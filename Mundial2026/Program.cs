using Microsoft.SemanticKernel;
using Mundial2026.Repositories;
using Mundial2026.Services;
using DotNetEnv;

Env.Load();

var openAiApiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

var builder = WebApplication.CreateBuilder(args);

var model = builder.Configuration["OpenAI:Model"];

builder.Services.AddSingleton<IStickerRepository, StickerRepository>();
builder.Services.AddSingleton<StickerService>();

builder.Services.AddSingleton(sp =>
{
    var kernelBuilder = Kernel.CreateBuilder();

    // LLM
    kernelBuilder.AddOpenAIChatCompletion(
        modelId: model!,
        apiKey: openAiApiKey!
    );

    var kernel = kernelBuilder.Build();
    var stickerService = sp.GetRequiredService<StickerService>();
    kernel.Plugins.AddFromObject(stickerService);
    return kernel;
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();