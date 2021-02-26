using System.Text;

namespace LinqExamples
{
    public class Person
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public override string ToString()
        {
            var newLine = System.Environment.NewLine;
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"Id: {Id}{newLine}");
            stringBuilder.Append($"First name: {FirstName}{newLine}");
            stringBuilder.Append($"Last rate: {LastName}{newLine}");
            stringBuilder.Append($"Gender: {Gender}{newLine}");
            return stringBuilder.ToString();
        }
    }
}
