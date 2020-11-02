using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
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
    }
}
