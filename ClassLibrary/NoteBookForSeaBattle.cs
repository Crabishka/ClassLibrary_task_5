using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class NoteBookForSeaBattle : NoteBook
    {
        private List<bool> gameResults;

        private string name;

        public void addResult(bool result)
        {
            gameResults.Add(result);
            if (result)
            {
            
                append("Win!");
            }
            else
            {
                append("Lose:(");
            }
        }

        public void changeName(string name)
        {
            append("New Player");
            this.name = name;
        }


        public NoteBookForSeaBattle(string data, string title, string additionalInfo, List<bool> gameResults, string name) : base(data, title, additionalInfo)
        {
            this.gameResults = gameResults;
            this.name = name;
        }
    }
}