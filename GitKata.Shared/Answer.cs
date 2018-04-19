namespace GitKata.Shared
{
    public class Answer : IGradable
    {
        public decimal Grade { get; set; }
        public void Retake(decimal grade)
        {
            Grade = grade * (decimal).95;
        }
    }
}