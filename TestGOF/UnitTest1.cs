using System.IO;

namespace TestGOF
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNurseCanTreatPatient()
        {
            StringWriter stringWriter = new();
            Console.SetOut(stringWriter);

            Nurse nurse = new Nurse();
            Doctor doctor = new Doctor();
            Surgeon surgeon = new Surgeon();
            nurse.SetSuccessor(doctor);
            doctor.SetSuccessor(surgeon);

            Patient patient = new Patient(2);

            nurse.TreatPatient(patient);
            Assert.AreEqual("Õde ravis patsiendi", stringWriter.ToString().Trim());
        }

        [TestMethod]
        public void TestDoctorCanTreatPatient()
        {
            StringWriter stringWriter = new();
            Console.SetOut(stringWriter);

            Nurse nurse = new Nurse();
            Doctor doctor = new Doctor();
            Surgeon surgeon = new Surgeon();
            nurse.SetSuccessor(doctor);
            doctor.SetSuccessor(surgeon);

            Patient patient = new Patient(5);

            nurse.TreatPatient(patient);

            Assert.AreEqual("Arst ravis patsiendi", stringWriter.ToString().Trim());

        }

        [TestMethod]
        public void TestSurgeonCanTreatPatient()
        {
            StringWriter stringWriter = new();
            Console.SetOut(stringWriter);

            Nurse nurse = new Nurse();
            Doctor doctor = new Doctor();
            Surgeon surgeon = new Surgeon();
            nurse.SetSuccessor(doctor);
            doctor.SetSuccessor(surgeon);

            Patient patient = new Patient(9);

            nurse.TreatPatient(patient);
            Assert.AreEqual("Kirurg ravis patsiendi", stringWriter.ToString().Trim());
        }

        [TestMethod]
        public void TestNoOneCanTreatPatient()
        {
            StringWriter stringWriter = new();
            Console.SetOut(stringWriter);

            Nurse nurse = new Nurse();
            Doctor doctor = new Doctor();
            Surgeon surgeon = new Surgeon();
            nurse.SetSuccessor(doctor);
            doctor.SetSuccessor(surgeon);

            Patient patient = new Patient(12);

            nurse.TreatPatient(patient);
            Assert.AreEqual("Keegi ei suuda enam patsienti ravida", stringWriter.ToString().Trim());
        }

    }
}