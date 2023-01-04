public class Doctor : MedicalProfessional
{
    public Doctor()
    {
        this.MinHealthLevel = 3;
        this.MaxHealthLevel = 7;
    }

    public override void TreatPatient(Patient patient)
    {
        if (patient.HealthLevel >= this.MinHealthLevel && patient.HealthLevel <= this.MaxHealthLevel)
        {
            Console.WriteLine("Arst ravis patsiendi");
        }
        else
        {
            this.Successor.TreatPatient(patient);
        }
    }
}
//V. Sarcar, Design Patterns in C#, 22. Chain of Responsibility Pattern, 2018
