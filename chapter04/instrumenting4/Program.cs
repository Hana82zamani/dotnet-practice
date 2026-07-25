using Microsoft.Extensions.Configuration;

ConfigurationBuilder builder =new();

builder.SetBasePath(Directory.GetCurrentDirectory());

builder.AddJsonFile("appsettings.json");

IConfigurationRoot configuration = builder.Build();

Console.WriteLine($"name : {configuration["Student:Name"]}");

int age =int.Parse(configuration ["Student:Age"]);

Console.WriteLine($"Age : {age}");

if (age >= 18)
{
    Console.WriteLine("adult");
}
else
{
    Console.WriteLine("minor");
}