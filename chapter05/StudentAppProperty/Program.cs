using StudentLibProperty;
 
 Student student =new();

 try
{
    student.Score=-2;
    
    Console.WriteLine(student.Score);
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
    
}
