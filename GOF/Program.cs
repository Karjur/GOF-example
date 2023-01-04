using System;

public class Program
{
    static void Main(string[] args)
    {
        Patient patient = new Patient(8);

        Nurse nurse = new Nurse();
        Doctor doctor = new Doctor();
        Surgeon surgeon = new Surgeon();

        nurse.SetSuccessor(doctor);
        doctor.SetSuccessor(surgeon);

        nurse.TreatPatient(patient);
    }
}

//V. Sarcar, Design Patterns in C#, 22. Chain of Responsibility Pattern, 2018