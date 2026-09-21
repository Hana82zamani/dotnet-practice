namespace StudentLib;

public class Student
{
   public string Name="";
   public double Score;

  static  double GetAverage(Student s1, Student s2)
{
    return (s1.Score+s2.Score)/2;
    
}
public double GetAverage(Student student)
{
 return GetAverage(this,student);
}
public static double operator +(Student s1, Student s2)
{
    return GetAverage(s1, s2);
}


}
// static استفاده از 
// instance استفاده از 
//  Operator Overloading استفاده از 