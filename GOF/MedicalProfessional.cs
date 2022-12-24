
// The MedicalProfessional abstract class represents a medical professional
// who can treat a patient if their health level is within a certain range
public abstract class MedicalProfessional
{
    protected MedicalProfessional Successor { get; set; }

    protected int MinHealthLevel { get; set; }
    protected int MaxHealthLevel { get; set; }

    public void SetSuccessor(MedicalProfessional successor)
    {
        this.Successor = successor;
    }

    public abstract void TreatPatient(Patient patient);
}
