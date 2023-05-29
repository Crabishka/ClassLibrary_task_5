using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class NoteBookForHomeWork : NoteBook
    {
        private String subject;

        private List<int> exercise;

        public void addExercise(int number)
        {
            append("Exercise nubmer " + number);
            exercise.Add(number);
        }

        public void finishExercise(int number)
        {
            append("finish");
            exercise.Remove(number);
        }

        public NoteBookForHomeWork(string data, string title, string additionalInfo, string subject, List<int> exercise) :
            base(data, title, additionalInfo)
        {
            this.subject = subject;
            this.exercise = exercise;
        }
    }
}