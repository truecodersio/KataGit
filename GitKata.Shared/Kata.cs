using System.Collections.Generic;

namespace GitKata.Shared
{
    /// <summary>
    /// A Kata is a repeated set of question/answer that will not dismiss until satisfied by correctness
    /// </summary>
    public abstract class Kata
    {
        protected readonly List<Question> Questions;
        protected readonly AnswerQueue<IGradable> AnswerQueue =null;
       
        protected Kata(params Question[] questions)
        {
            Questions = new List<Question>(questions);
            AnswerQueue = new AnswerQueue<IGradable>(questions.Length);
        }

        /// <summary>
        /// Grade needed to stop looping
        /// </summary>
        public decimal MinimumGrade { get; set; }


        public virtual bool ShouldContinue => true;
        //TODO : Fix
           // AnswerQueue.Count >= Questions.Count || MinimumGrade < AnswerQueue.Grade;

        /// <summary>
        /// Pushes the answer onto the AnswerQueue
        /// </summary>
        /// <param name="answer"></param>
        public abstract Question AnswerQuestionAndGetNext(string answer);

       
        /// <summary>
        /// Get the First Question.  All the rest should be done through AnswerQuestionAndGetNext
        /// </summary>
        /// <returns></returns>
        public abstract Question GetFirstQuestion();
    }
}