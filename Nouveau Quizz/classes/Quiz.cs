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
        public Question[] Questions { get; set; }
        public Response[] Responses { get; set; }
        public UserResponse[] UserResponses { get; set; }
        public Data QuizzData { get; set; }

    }
}
