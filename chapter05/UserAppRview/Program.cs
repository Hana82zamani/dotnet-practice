using UserLibRview;

User[] users =
{
    new Student
    {
        Username="Hana",
        Age=17,
        CourseCount=6,
        Contact = new ContactInfo("hana@mail.com", 123456789)
    },
    new Student
    {
        Username="Ali",
        Age=22,
        CourseCount=2,
        Contact = new ContactInfo("ali@mail.com", 123456789)        
    },
    new Admin
    {
        Username="Sara",
        AccessLevel=10,
        LoginCount=50,
        Contact = new ContactInfo("sara@mail.com", 123456789)

    },
    new Admin
    {
        Username="Reza",
        AccessLevel=3,
        LoginCount=5,
        Contact = new ContactInfo("reza@mail.com", 123456789)
    }

};

ContactInfo newContact = users[1].Contact with
{
    Email = "newali@mail.com"
};
 
foreach (User user in users)
{
    string status = user switch
    {
        Student { Age: < 18 , CourseCount: >= 5}=>"Young Active Student",
        Student { Age: >=18 , CourseCount: >= 5}=>"Adult Active Student",
        Student {CourseCount: < 5}=>"Inactive Student",
        Admin   {AccessLevel: >= 8 , LoginCount:>= 20}=>"Super Admin",
        Admin => "Normal Admin",
        _ => "Unknown"
    };
    Console.WriteLine($"{user.Username}:{status}");
    
}

Console.WriteLine(users[1].Contact.Email);
Console.WriteLine(newContact.Email);

var (email, phone) = users[0].Contact;

Console.WriteLine(email);
Console.WriteLine(phone);