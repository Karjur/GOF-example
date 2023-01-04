public class Nurse : MedicalProfessional
{
    public Nurse()
    {
        this.MinHealthLevel = 1;
        this.MaxHealthLevel = 2;
    }

    public override void TreatPatient(Patient patient)
    {
        if (patient.HealthLevel >= this.MinHealthLevel && patient.HealthLevel <= this.MaxHealthLevel)
        {
            Console.WriteLine("Õde ravis patsiendi");
        }
        else
        {
            this.Successor.TreatPatient(patient);
        }
    }
}
//V. Sarcar, Design Patterns in C#, 22. Chain of Responsibility Pattern, 2018
