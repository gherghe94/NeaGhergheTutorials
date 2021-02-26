namespace LinqExamples
{
    using System.Collections.Generic;
    using System.Linq;

    public static class JobRepository
    {
        private static IList<Job> _programmerJobs = new List<Job>
        {
            new Job
            {
                Id = 1,
                Title = "Intern Programmer",
                Rank = Rank.Intern,
                JobType = JobType.Programmer,
            },
            new Job
            {
                Id = 2,
                Title = "Junior Programmer",
                Rank = Rank.Junior,
                JobType = JobType.Programmer,
            },
            new Job
            {
                Id = 3,
                Title = "Mid Programmer",
                Rank = Rank.Middle,
                JobType = JobType.Programmer,
            },
            new Job
            {
                Id = 3,
                Title = "Senior Programmer",
                Rank = Rank.Senior,
                JobType = JobType.Programmer,
            },
            new Job
            {
                Id = 4,
                Title = "Expert Programmer",
                Rank = Rank.Expert,
                JobType = JobType.Programmer,
            },
        };

        private static IList<Job> _testerJobs = new List<Job>
        {
            new Job
            {
                Id = 10,
                Title = "Intern Tester",
                Rank = Rank.Intern,
                JobType = JobType.Tester,
            },
            new Job
            {
                Id = 11,
                Title = "Junior Test Enginer",
                Rank = Rank.Junior,
                JobType = JobType.Tester,
            },
            new Job
            {
                Id = 12,
                Title = "Test Engineer",
                Rank = Rank.Middle,
                JobType = JobType.Tester,

            },
            new Job
            {
                Id = 13,
                Title = "Senior Test Engineer",
                Rank = Rank.Senior,
                JobType = JobType.Tester,
            },
            new Job
            {
                Id = 14,
                Title = "Automation Test Engineer",
                Rank = Rank.Expert,
                JobType = JobType.Tester,
            },
        };

        private static IList<Job> _managerJobs = new List<Job>
        {
            new Job
            {
                Id = 20,
                Title = "Assistent",
                Rank = Rank.Intern,
                JobType = JobType.Manager,
            },
            new Job
            {
                Id = 21,
                Title = "Scrum Master",
                Rank = Rank.Junior,
                JobType = JobType.Manager,
            },
            new Job
            {
                Id = 22,
                Title = "Product Owner",
                Rank = Rank.Middle,
                JobType = JobType.Manager,
            },
            new Job
            {
                Id = 23,
                Title = "Project Manager",
                Rank = Rank.Senior,
                JobType = JobType.Manager,
            },
            new Job
            {
                Id = 24,
                Title = "Project Director",
                Rank = Rank.Expert,
                JobType = JobType.Manager,
            },
        };

        public static IList<Job> GetAllJobs()
        {
            return _programmerJobs
                .Concat(_testerJobs)
                .Concat(_managerJobs)
                .ToList();
        }

        public static IList<Job> GetProgrammerJobs()
        {
            return _programmerJobs.ToList();
        }

        public static IList<Job> GetTesterJobs()
        {
            return _testerJobs.ToList();
        }

        public static IList<Job> GetManagerJobs()
        {
            return _managerJobs.ToList();
        }

        public static Job GetRankedProgrammerJob(Rank rank)
        {
            return GetProgrammerJobs().First(p => p.Rank == rank);
        }

        public static Job GetRankedTesterJob(Rank rank)
        {
            return GetTesterJobs().First(p => p.Rank == rank);
        }

        public static Job GetRankedManagerJob(Rank rank)
        {
            return GetManagerJobs().First(p => p.Rank == rank);
        }
    }
}
