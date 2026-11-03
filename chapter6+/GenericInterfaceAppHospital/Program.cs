using GenricInterfaceLibHospital;

Repository<Doctor>doctors=new();
doctors.Add(new Doctor
{
    Id= 101,
    Name= "Dr. Ahmadi",
    Specialty= "Cardiology"

});
doctors.Add(new Doctor
{
    Id= 102,
    Name= "Dr. Rezai",
    Specialty= "Neurology"

});
doctors.GetAll();
foreach (Doctor doctor in doctors.GetAll())
{
    Console.WriteLine($"{doctor.Id}-{doctor.Name}-{doctor.Specialty}");
}
Repository<Appointment>appointments=new();
appointments.Add(new Appointment
{
 Id=1 ,   
PatientName="Hana",
DoctorName="Dr. Ahmadi",
Date=new DateTime(2026,09,22)
});
appointments.GetAll();

foreach (Appointment appointment in appointments.GetAll())
{
Console.WriteLine
($"{appointment.Id}-{appointment.PatientName}-{appointment.DoctorName}-{appointment.Date}");
    
}