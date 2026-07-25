using Microsoft.Extensions.Configuration;

ConfigurationBuilder builder =new();

builder.SetBasePath(Directory.GetCurrentDirectory());

builder.AddJsonFile("appsettings.json");

IConfigurationRoot configuration = builder.Build();

Console.WriteLine(configuration["Game:name"]);