namespace StudentLibIndex;

public class StudentList
{
    public List<string> students=new();

    public string this[int index]
    {
        get
        {
            return students[index];

        }
        set
        {
            students[index]=value;
        }
    }

}
