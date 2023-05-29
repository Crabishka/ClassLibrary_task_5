namespace ClassLibrary
{
    public abstract class NoteBook : Paper
    {
        public string data { get; set; }
        public string title { get; set; }
        public string additionalInfo { get; set; }

        public void append(string text)
        {
            data += text;
        }

        protected NoteBook(string data, string title, string additionalInfo)
        {
            this.data = data;
            this.title = title;
            this.additionalInfo = additionalInfo;
        }

        public string readLine(int number)
        {
            string[] lines = data.Split('\n');
            if (number < lines.Length)
            {
                return lines[number];
            }

            return "";
        }

        public void deleteLine(int number)
        {
            string[] lines = data.Split('\n');
            if (number < lines.Length)
            {
                lines[number] = string.Empty;
                string updatedText = string.Join("\n", lines);
            }
        }
    }
}