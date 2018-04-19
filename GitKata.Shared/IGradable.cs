namespace GitKata.Shared
{
    public interface IGradable
    {
        /// <summary>
        /// The grade for the answer
        /// </summary>
        decimal Grade { get; }

        void Retake(decimal grade);
    }
}