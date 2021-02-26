namespace LinqExamples
{
    using System.Collections.Generic;
    using System.Linq;

    public static class EmployeeRepository
    {
        private static IList<Employee> _programmers = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                FirstName = "Andrei",
                LastName = "Gherghelau",
                EmploymentType = EmploymentType.FullTime,
                Gender = Gender.Male,
                HourlyRate = 50M,
                Job = JobRepository.GetRankedProgrammerJob(Rank.Senior),
            },
            new Employee
            {
                Id = 2,
                FirstName = "Naruto",
                LastName = "Uzumaki",
                EmploymentType = EmploymentType.PartTime,
                Gender = Gender.Male,
                HourlyRate = 35M,
                Job = JobRepository.GetRankedProgrammerJob(Rank.Middle),
            },
            new Employee
            {
                Id = 3,
                FirstName = "Botan",
                LastName = "Gea",
                EmploymentType = EmploymentType.FullTime,
                Gender = Gender.Female,
                HourlyRate = 40M,
                Job = JobRepository.GetRankedProgrammerJob(Rank.Middle),
            }
        };

        private static IList<Employee> _testers = new List<Employee>
        {
            new Employee
            {
                Id = 11,
                FirstName = "Tibor",
                LastName = "Csabo",
                EmploymentType = EmploymentType.FullTime,
                Gender = Gender.Male,
                HourlyRate = 25M,
                Job = JobRepository.GetRankedTesterJob(Rank.Middle),
            },
            new Employee
            {
                Id = 12,
                FirstName = "Sorin",
                LastName = "Parcalabescu",
                EmploymentType = EmploymentType.PartTime,
                Gender = Gender.Male,
                HourlyRate = 10M,
                Job = JobRepository.GetRankedTesterJob(Rank.Junior),
            },
            new Employee
            {
                Id = 13,
                FirstName = "Bianca",
                LastName = "Tomescu",
                EmploymentType = EmploymentType.FullTime,
                Gender = Gender.Female,
                HourlyRate = 45M,
                Job = JobRepository.GetRankedTesterJob(Rank.Expert),
            },
            new Employee
            {
                Id = 14,
                FirstName = "Viorel",
                LastName = "Zitea",
                EmploymentType = EmploymentType.FullTime,
                Gender = Gender.Male,
                HourlyRate = 25M,
                Job = JobRepository.GetRankedTesterJob(Rank.Senior),
            },
            new Employee
            {
                Id = 15,
                FirstName = "Corina",
                LastName = "Atea",
                EmploymentType = EmploymentType.PartTime,
                Gender = Gender.Female,
                HourlyRate = 25M,
                Job = JobRepository.GetRankedTesterJob(Rank.Intern),
            },
            new Employee
            {
                Id = 16,
                FirstName = "Darius",
                LastName = "Varga",
                EmploymentType = EmploymentType.PartTime,
                Gender = Gender.Male,
                HourlyRate = 65M,
                Job = JobRepository.GetRankedTesterJob(Rank.Expert),
            }
        };

        private static IList<Employee> _managers = new List<Employee>
        {
            new Employee
            {
                Id = 21,
                FirstName = "Tal",
                LastName = "Parda",
                EmploymentType = EmploymentType.FullTime,
                Gender = Gender.Male,
                HourlyRate = 100M,
                Job = JobRepository.GetRankedManagerJob(Rank.Senior),
            },
            new Employee
            {
                Id = 22,
                FirstName = "Fatima",
                LastName = "Bobz",
                EmploymentType = EmploymentType.PartTime,
                Gender = Gender.Female,
                HourlyRate = 60M,
                Job = JobRepository.GetRankedManagerJob(Rank.Junior),
            },
            new Employee
            {
                Id = 23,
                FirstName = "Clara",
                LastName = "Indoielnicu",
                EmploymentType = EmploymentType.FullTime,
                Gender = Gender.Female,
                HourlyRate = 10M,
                Job = JobRepository.GetRankedManagerJob(Rank.Intern),
            },
            new Employee
            {
                Id = 24,
                FirstName = "Simon",
                LastName = "Lupin",
                EmploymentType = EmploymentType.FullTime,
                Gender = Gender.Male,
                HourlyRate = 200M,
                Job = JobRepository.GetRankedManagerJob(Rank.Expert),
            },
        };

        public static IList<Employee> GetAllEmployees()
        {
            return _programmers
                .Concat(_testers)
                .Concat(_managers)
                .ToList();
        }
    }
}
