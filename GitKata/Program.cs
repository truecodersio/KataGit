using System;
using System.Collections.Generic;
using GitKata.Shared;

namespace GitKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Git Kata!");
            var questions = new List<Question>
            {
                new Question
                {
                    Text =  "First we need to make a directory name 'test'",
                    DesiredAnswer = "mkdir test"
                },
                new Question
                {
                    Text= "Now we need to change into that directory",
                    DesiredAnswer = "cd test"
                },
                new Question
                {
                    Text = "Let's init our new repository!",
                    DesiredAnswer = "git init"
                },
                new Question
                {
                    Text="Let's add all of the files",
                    DesiredAnswer = "git add *"
                },
                new Question
                {
                    Text ="Let's check the status",
                    DesiredAnswer = "git status"
                },
                new Question
                {
                    Text = "Let's do our first commit with a comment of 'Initial add'",
                    DesiredAnswer = "git commit -m \"Initial add\""
                },
                new Question
                {
                    Text = "Everything clean?  Let's check the status again.",
                    DesiredAnswer = "git status"
                },
                new Question
                {
                    Text="Let's add a remote to push it to named origin with a value of 'user@sourcecontrol.com:gitkata.git'",
                    DesiredAnswer = "git remote add origin user@sourcecontrol.com:gitkata.git"
                },
                new Question
                {
                    Text = "Let's push it to origin so we have another copy somewhere",
                    DesiredAnswer = "git push origin master"
                },
                new Question
                {
                    Text= "Time for another project. Let's go up a directory",
                    DesiredAnswer = "cd .."
                },
                new Question
                {
                    Text = "Let's clone a new project from 'user@someplace.com:projectname.git'",
                    DesiredAnswer = "git clone user@someplace.com:projectname.git"
                },
                new Question
                {
                    Text = "What remote urls do we have?",
                    DesiredAnswer = "git remote -v"
                }
            };

            var kata = new SequencedKata(questions.ToArray());
            var ques = kata.GetFirstQuestion();
            while (kata.ShouldContinue)
            {
                Console.WriteLine("[{0}] {1}", kata.Grade , ques.Text);
                var ans = Console.ReadLine();
                ques =  kata.AnswerQuestionAndGetNext(ans);

            }

            Console.WriteLine("Congratulations, you've defeated me.  Press enter to quit");
            Console.ReadLine();
        }
    }
}
