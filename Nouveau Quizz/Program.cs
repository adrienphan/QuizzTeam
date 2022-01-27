using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Nouveau_Quizz.classes;

namespace Nouveau_Quizz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = JsonFileManage.GetJson();

            Console.WriteLine(quiz);
        }
    }
}
