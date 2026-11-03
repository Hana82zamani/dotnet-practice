namespace GenricInterfaceLibHospital;

public class Doctor
{
public int Id;
public string Name ="";
public string Specialty ="";

}
public class Appointment
{
public int Id;
public string PatientName="";
public string DoctorName="";
public DateTime Date;
}

public interface IRepository<T>
{
    void Add(T item);

    List<T>GetAll();
}
public class Repository<T>: IRepository<T>
{
    public List<T>items=new();
    public void Add(T item)
    {
        items.Add(item);
    }
    public List<T> GetAll()
    {
       return items; 
    }
}