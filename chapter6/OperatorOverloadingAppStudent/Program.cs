using StudentLib;

Student hana = new()
{
    Name = "Hana",
    Score = 90
};

Student ali = new()
{
    Name = "Ali",
    Score = 70
};

double result = hana + ali;

Console.WriteLine(result);
