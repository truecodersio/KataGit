using System;

namespace GitKata.Shared
{
    public class RandomKata : Kata
    {
        private Question _currentQuestion = null;
        
        public override Question AnswerQuestionAndGetNext(string answer)
        {
            var isCorrect = _currentQuestion.DesiredAnswer == answer;
            AnswerQueue.Enqueue(new TrueFalseAnswer(isCorrect));
            if (isCorrect)
                _currentQuestion = Questions.GetRandom();
            return _currentQuestion;
        }


        public override Question GetFirstQuestion()
        {
            _currentQuestion = Questions.GetRandom();
            return _currentQuestion;
        }
    }
}