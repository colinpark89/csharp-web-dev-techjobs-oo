using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreNotEqual(job1.Id, job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            
            Assert.AreEqual("Product tester", job1.Name);
            Assert.AreEqual("ACME", job1.EmployerName.ToString());
            Assert.AreEqual("Desert", job1.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job1.JobType.ToString());
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.ToString());
        }
        [TestMethod]
        public void TestJobsForEquality()
        {

            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Equals(job1, job2);

        }

        [TestMethod]
        public void TestForToString()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(job1.ToString()[0], '\n');
            Assert.AreEqual(job1.ToString().Last(), '\n');
    
        }

        [TestMethod]
        public void TestForLabel()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(job1.ToString(), 
                $"\n ID: {job1.Id} \n" +
                $"Name: {job1.Name} \n" +
                $"Employer: {job1.EmployerName} \n" +
                $"Location: {job1.EmployerLocation} \n" +
                $"Position Type: {job1.JobType} \n" +
                $"Core Competency: {job1.JobCoreCompetency} \n");
        }

        [TestMethod]
        public void TestForDataNotAvailable()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), null, new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(job1.ToString(),
                $"\n ID: {job1.Id} \n" +
                $"Name: {job1.Name} \n" +
                $"Employer: {job1.EmployerName} \n" +
                $"Location: Data not available \n" +
                $"Position Type: {job1.JobType} \n" +
                $"Core Competency: {job1.JobCoreCompetency} \n");
        }
    }
}
