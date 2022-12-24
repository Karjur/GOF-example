namespace TestGOF
{
    [TestClass]
    public class UnitTest1
    {
        // Test that the nurse can treat a patient with a health level within her range
[TestMethod]
public void TestNurseCanTreatPatient()
{
    // Create a nurse and set up the chain of responsibility
    Nurse nurse = new Nurse();
    Doctor doctor = new Doctor();
    Surgeon surgeon = new Surgeon();
    nurse.SetSuccessor(doctor);
    doctor.SetSuccessor(surgeon);

    // Create a patient with a health level within the nurse's range
    Patient patient = new Patient(2);

    // The nurse should be able to treat the patient
    nurse.TreatPatient(patient);
    Assert.AreEqual("Õde ravis patsiendi", Console.Out.ToString().Trim());
}

// Test that the doctor can treat a patient with a health level within her range
[TestMethod]
public void TestDoctorCanTreatPatient()
{
    // Create a nurse and set up the chain of responsibility
    Nurse nurse = new Nurse();
    Doctor doctor = new Doctor();
    Surgeon surgeon = new Surgeon();
    nurse.SetSuccessor(doctor);
    doctor.SetSuccessor(surgeon);

    // Create a patient with a health level within the doctor's range
    Patient patient = new Patient(5);

    // The doctor should be able to treat the patient
    nurse.TreatPatient(patient);
    Assert.AreEqual("Arst ravis patsiendi", Console.Out.ToString().Trim());
}

// Test that the surgeon can treat a patient with a health level within her range
[TestMethod]
public void TestSurgeonCanTreatPatient()
{
    // Create a nurse and set up the chain of responsibility
    Nurse nurse = new Nurse();
    Doctor doctor = new Doctor();
    Surgeon surgeon = new Surgeon();
    nurse.SetSuccessor(doctor);
    doctor.SetSuccessor(surgeon);

    // Create a patient with a health level within the surgeon's range
    Patient patient = new Patient(9);

    // The surgeon should be able to treat the patient
    nurse.TreatPatient(patient);
    Assert.AreEqual("Kirurg ravis patsiendi", Console.Out.ToString().Trim());
}

// Test that no one can treat a patient with a health level outside the range of all medical professionals
[TestMethod]
public void TestNoOneCanTreatPatient()
{
    // Create a nurse and set up the chain of responsibility
    Nurse nurse = new Nurse();
    Doctor doctor = new Doctor();
    Surgeon surgeon = new Surgeon();
    nurse.SetSuccessor(doctor);
    doctor.SetSuccessor(surgeon);

    // Create a patient with a health level outside the range of all medical professionals
    Patient patient = new Patient(12);

    // No one should be able to treat the patient
    nurse.TreatPatient(patient);
    string vastus = Console.ReadLine();
    Assert.AreEqual("No one was able to treat the patient.", Console.Out.ToString().Trim());
}

    }
}