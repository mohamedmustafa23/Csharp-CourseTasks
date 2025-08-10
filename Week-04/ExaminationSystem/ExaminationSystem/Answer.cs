using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Answer
    {
        public int id = 0;
        public string Text { get; set; }

        public Answer(int ID ,string text)
        {
            id = ID;
            Text = text;
        }
    }
}
