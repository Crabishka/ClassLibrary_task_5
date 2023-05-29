using System;

namespace ClassLibrary
{
    public class NoteBookForPainting : NoteBook
    {
        private int widht { get; set; }
        private int height { get; set; }

        public void paint(int number, String image)
        {
            for (int i = 0; i < number; i++)
            {
                append(image);
            }
        }

        public void paintAll(string image)
        {
            paint(widht * height, image);
        }

        public NoteBookForPainting(string data, string title, string additionalInfo, int widht, int height) : base(data,
            title, additionalInfo)
        {
            this.widht = widht;
            this.height = height;
        }
    
    }
}