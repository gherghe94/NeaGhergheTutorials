using System.Text;

namespace LinqExamples
{
    public class Employee : Person
    {
        public decimal HourlyRate { get; set; }

        public EmploymentType EmploymentType { get; set; }

        public Job Job { get; set; }

        public override string ToString()
        {
            var newLine = System.Environment.NewLine;
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(base.ToString());
            stringBuilder.Append($"Employment type: {EmploymentType}{newLine}");
            stringBuilder.Append($"Hourly rate: {HourlyRate}$/hour{newLine}");
            stringBuilder.Append($"\tJob{newLine}");
            stringBuilder.Append($"{Job}{newLine}");
            return stringBuilder.ToString();
        }
    }
}
