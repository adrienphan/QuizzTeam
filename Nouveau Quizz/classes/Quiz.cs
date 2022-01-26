using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nouveau_Quizz.classes
{
    internal class Quiz
    {
        public User[] Users { get; set; }
        public string[] Questions { get; set; }
        public string[] RightAnswers { get; set; }
        public string[] UserAnswers { get; set; }
        public QuizData Data { get; set; }

    }
}
