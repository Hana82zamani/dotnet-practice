
Dictionary<int, string>Student =new();

Student.Add(1,"Hana");
Student.Add(2,"Ali");
Student.Add(3,"Sara");

Console.WriteLine(Student[2]);

// متفاوت ساخته شده dictionary دوتا 

Dictionary<string,int>Score =new();

Score.Add("Hana",95);
Score.Add("Ali",90);
Score.Add("Sara",70);

Console.WriteLine(Score["Hana"]);