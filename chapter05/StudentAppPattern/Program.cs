using StudentLibPattern;

Student[] students =
{
    new SchoolStudent
    {
        Name = "Hana",
        Age = 17,
        Score = 95
    },

    new SchoolStudent
    {
        Name = "Ali",
        Age = 16,
        Score = 70
    },

    new SchoolStudent
    {
        Name = "Sara",
        Age = 18,
        Score = 88
    },

    new UniversityStudent
    {
        Name = "Mina",
        Credits = 120,
        GPA = 18.5
    },

    new UniversityStudent
    {
        Name = "Reza",
        Credits = 80,
        GPA = 14.5
    }
};
foreach (Student student in students)
{
    string level = student switch
    {
        SchoolStudent {Age:>=17, Score:>=90 }=> "Excellent",
        SchoolStudent {Score: >=80}=> "Good",
        SchoolStudent => " needs improvement",
        UniversityStudent{GPA:>=18 ,Credits:>=100}=> "outstanding",
        UniversityStudent {GPA :>=16}=> "Good",
        UniversityStudent => "average",
        _ => "unknow"

    };

    Console.WriteLine($"{student.Name}: {level}");
}