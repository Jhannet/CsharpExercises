using System;
using System.Collections.Generic;

namespace CsharpExercises.Exercises.Exercise15
{
    public interface ITestpaper
    {
        string Subject { get; }
        string[] MarkScheme { get; }
        string PassMark { get; }
    }

    public interface IStudent
    {
        string[] TestsTaken { get; }
        void TakeTest(ITestpaper paper, string[] answers);
    }

    public class Testpaper : ITestpaper
    {
        public string Subject { get; set; } = string.Empty;

        public string[] MarkScheme { get; set; }

        public string PassMark { get; set; } = string.Empty;

        public Testpaper (string subject, string[] markScheme, string passMark)
        { 
            Subject = subject;
            MarkScheme = markScheme;
            PassMark = passMark;
        }
    }

    public class Student : IStudent
    {
        private List<string> _testsTaken = new List<string>();
        public string[] TestsTaken { 
            get {
                if (_testsTaken.Count > 0)
                    _testsTaken.Sort((test1, test2) => string.Compare(test1.Split(':')[0], test2.Split(':')[0]));
                else
                    return new string[] { "No tests taken" };

                return _testsTaken.ToArray();
            }
        }

        public void TakeTest(ITestpaper paper, string[] answers)
        {
            int correctAnswersCount = 0;
            for (int i=0; i < answers.Length; i++)
            { 
                if (answers[i] == paper.MarkScheme[i])
                    correctAnswersCount++;
            }

            int testPercentage = (int)Math.Ceiling((decimal)(correctAnswersCount*100) / paper.MarkScheme.Length);
            string passTest = testPercentage >= int.Parse(paper.PassMark.Replace('%', ' ').Trim()) ? "Passed" : "Failed";

            string testResult = $"{paper.Subject}: {passTest}! ({testPercentage}%)";
            _testsTaken.Add(testResult);
        }
    }
}
