namespace StudentLibComparable;

public class Student  : IComparable<Student>
{
    public string name="";

    public int age;

public int CompareTo(Student? other)
{
    if (other is null) return 1; 

 return age.CompareTo( other.age);
}
};