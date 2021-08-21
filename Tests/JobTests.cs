using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

            Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            int id = 3; //check number of jobs instatiated 
            string jobName = "Product tester";
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("Quality Control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");


            Job job = new Job(jobName, employer, location, positionType, coreCompetency);

            Assert.AreEqual(jobName, job.Name);
            Assert.AreEqual(employer, job.EmployerName);
            Assert.AreEqual(location, job.EmployerLocation);
            Assert.AreEqual(positionType, job.JobType);
            Assert.AreEqual(coreCompetency, job.JobCoreCompetency);
            Assert.AreEqual(id, job.Id);            
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            string jobName = "Test Subject";
            Employer employer = new Employer("Gizmonic Institute");
            Location location = new Location("Satellite of Love");
            PositionType positionType = new PositionType("Sanity Checking");
            CoreCompetency coreCompetency = new CoreCompetency("Willpower");

            Job job4 = new Job(jobName, employer, location, positionType, coreCompetency);
            Job job5 = new Job(jobName, employer, location, positionType, coreCompetency);

            Assert.IsFalse(job4.Equals(job5));
        }


    }
}
