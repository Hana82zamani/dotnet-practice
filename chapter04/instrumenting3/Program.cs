using Microsoft.Extensions.Configuration;

ConfigurationBuilder builder =new();

builder.SetBasePath(Directory.GetCurrentDirectory());

builder.AddJsonFile("appsettings.json");

IConfigurationRoot configuration = builder.Build();

Console.WriteLine($"book : {configuration["Book:Title"]}");

Console.WriteLine($"pages: {configuration["Book:Pages"]}");

Console.WriteLine($"price: {configuration["Book:Price"]}");