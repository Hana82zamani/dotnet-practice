
using UserLibCasting;

User[] users =
{
   
    new StudentUser
    {
        Username ="Ali",
        Grade=11
    },
    new TeacherUser
    {
        Username="Hana",
        Subject="Math"
    }
};
     
     // is استفاده از 
foreach (User user in users)
{
    user.ShowUser();


    if (user is TeacherUser teacherUser)
    {
   
        Console.WriteLine(teacherUser.Subject);
        
    }

    if (user is StudentUser studentUser)
    {
        Console.WriteLine(studentUser.Grade);
        
    }

}

// as استفاده از 
foreach (User user in users)
{
    user.ShowUser();

    TeacherUser? teacher = user as TeacherUser;

    if (teacher is not null)
    {
        Console.WriteLine(teacher.Subject);
    }

    StudentUser? student = user as StudentUser;

    if (student is not null)
    {
        Console.WriteLine(student.Grade);
    }
}