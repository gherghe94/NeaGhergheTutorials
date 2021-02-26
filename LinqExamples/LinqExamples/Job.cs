using System.Text;

namespace LinqExamples
{
    public class Job
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public Rank Rank { get; set; }

        public JobType JobType { get; set; }

        public override string ToString()
        {
            var newLine = System.Environment.NewLine;
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"Job type: {JobType}{newLine}");
            stringBuilder.Append($"Title: {Title}{newLine}");
            stringBuilder.Append($"Rank: {Rank}{newLine}");
            return stringBuilder.ToString();
        }
    }
}
