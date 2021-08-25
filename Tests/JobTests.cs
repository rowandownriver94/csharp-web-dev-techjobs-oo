using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        
        //Test to make sure the ID is incrementing properly 

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.IsFalse(job1.Id == job2.Id);
        }


        //Test to make sure the Job class's constructor is working properly

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            int id = 3; //check number of jobs instantiated 
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


        //Test to make sure 2 jobs with the same information are not equal (because their ID is always different)

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Test Subject", new Employer("Gizmonic Institute"), new Location("Satellite of Love"), new PositionType("Sanity Testing"), new CoreCompetency("Willpower"));
            Job job2 = new Job("Test Subject", new Employer("Gizmonic Institute"), new Location("Satellite of Love"), new PositionType("Sanity Testing"), new CoreCompetency("Willpower"));

            Assert.IsFalse(job1.Equals(job2));
        }


        //Test to make sure each field starts and ends on its own line

        [TestMethod]
        public void TestJobsForNewLineBeforeAndAfter()
        {
            Job job1 = new Job("Test Subject", new Employer("Gizmonic Institute"), new Location("Satellite of Love"), new PositionType("Sanity Testing"), new CoreCompetency("Willpower"));

            string jobListing = job1.ToString();

            Assert.IsTrue(jobListing.StartsWith('\n') && jobListing.EndsWith('\n'));
        }


        //Test to make sure the custom ToString method is working properly

        [TestMethod]
        public void TestJobsForReturnedString()
        { 

            Job job1 = new Job("Test Subject", new Employer("Gizmonic Institute"), new Location("Satellite of Love"), new PositionType("Sanity Testing"), new CoreCompetency("Willpower"));

            string testJob = $"\nID: {job1.Id}\n" +
                $"Name: {job1.Name}\n" +
                $"Employer: {job1.EmployerName.Value}\n" +
                $"Location: {job1.EmployerLocation.Value}\n" +
                $"Position Type: {job1.JobType.Value}\n" +
                $"Core Competency: {job1.JobCoreCompetency.Value}\n";

            Assert.AreEqual(job1.ToString(), testJob);

            
        }


        //Test to make sure empty fields return "Data not available"

        [TestMethod] 
        public void TestJobsForEmptyFields()
        {
            Job suspiciousJob = new Job("", new Employer("Gizmonic Institute"), new Location("Satellite of Love"), new PositionType(""), new CoreCompetency("Willpower"));

            string suspiciousJobString = $"\nID: {suspiciousJob.Id}\n" +
                $"Name: Data not available.\n" +
                $"Employer: {suspiciousJob.EmployerName.Value}\n" +
                $"Location: {suspiciousJob.EmployerLocation.Value}\n" +
                $"Position Type: Data not available.\n" +
                $"Core Competency: {suspiciousJob.JobCoreCompetency.Value}\n";

            Assert.AreEqual(suspiciousJob.ToString(), suspiciousJobString);
        }




    }
}
