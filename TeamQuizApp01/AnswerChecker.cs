using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamQuizApp01
{
    public class AnswerChecker
    {
        public bool CheckAnswer(Question q, int selectedIndex)
        {
            return q.CorrectIndex == selectedIndex;
        }
    }
}
