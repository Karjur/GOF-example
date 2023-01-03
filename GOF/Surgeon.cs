public class Surgeon : MedicalProfessional
{
    public Surgeon()
    {
        this.MinHealthLevel = 8;
        this.MaxHealthLevel = 10;
    }

    public override void TreatPatient(Patient patient)
    {
        if (patient.HealthLevel >= this.MinHealthLevel && patient.HealthLevel <= this.MaxHealthLevel)
        {
            Console.WriteLine("Kirurg ravis patsiendi");
        }
        else
        {
            Console.WriteLine("Keegi ei suuda enam patsienti ravida");
        }
    }
}
