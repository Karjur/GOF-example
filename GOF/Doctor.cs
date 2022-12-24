
// The Doctor class represents a doctor who can treat patients with moderate health problems
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
