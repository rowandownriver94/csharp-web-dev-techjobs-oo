using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }


        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {

            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
            
        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                Id == job.Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            //List<string> jobListings = new List<string>();

            if (Name == null && EmployerName == null && EmployerLocation == null && JobType == null && JobCoreCompetency == null)
            {
                return ($"\nOops! That job doesn't seem to exist.\n");
            }
            else
            {
                string jobListings = ($"\nID: {Id}\n" +
                                      $"Name: {(Name != "" ? Name : "Data not available.")}\n" +
                                      $"Employer: {(EmployerName.Value != "" ? EmployerName.Value : "Data not available.")}\n" +
                                      $"Location: {(EmployerLocation.Value != "" ? EmployerLocation.Value : "Data not available.")}\n" +
                                      $"Position Type: {(JobType.Value != "" ? JobType.Value : "Data not available.")}\n" +
                                      $"Core Competency: {(JobCoreCompetency.Value != "" ? JobCoreCompetency.Value : "Data not available.")}\n");

                return jobListings;


            }


        }
    }
}
