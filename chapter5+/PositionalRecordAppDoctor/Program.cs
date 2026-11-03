using PositionalRecordLibDoctor;

Appointment appointment = new("hana",new DateTime(2026,10,11));

Console.WriteLine($"{appointment.PatientName}={appointment.AppointmentDate}");