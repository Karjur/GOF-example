using System;

// The Client class sets up the chain of responsibility and passes a Patient object
// through the chain to be treated by the appropriate medical professional
public class Program
{
    static void Main(string[] args)
    {
        // Create a patient with a health level of 8
        Patient patient = new Patient(8);
        
        // Create the medical professionals and set up the chain of responsibility
        Nurse nurse = new Nurse();
        Doctor doctor = new Doctor();
        Surgeon surgeon = new Surgeon();

        nurse.SetSuccessor(doctor);
        doctor.SetSuccessor(surgeon);

        // Pass the patient through the chain of responsibility
        nurse.TreatPatient(patient);

        // Output:
        // The doctor has treated the patient.
    }
}