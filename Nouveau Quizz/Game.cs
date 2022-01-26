using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nouveau_Quizz
{
    internal class Game
    {
        //read questions from jsconfig1
        private static string[] GetQuestions()
        {
            //DEBUG: remplacer par la vraie methode
            string[] questions = new string[] {
                "Quel est le prénom de Picsou ?",
                "Comment s'appelle la colline ou Picsou a son coffre ?",
                "D'ou vient le premier sous de Picsou ?",
                "Combien de neveux a Donald Duck ?"
            };
            return questions;
        }
        private static string[] GetRightAnswers()
        {
            string[] rightanswers = {"Balthazar",
                "Killmotor",
                "Amérique",
                "3"
            };
            return rightanswers;
        }
        private static string[] AskQuestions(string[] questions, string[] rightanswers)
        {
            int score = 0;
            string[] userAnswers = new string[4];

            foreach (string question in questions)
            {
                Console.Clear();
                //Display question
                Console.WriteLine(question);
                //Read user answer and writes it to userAnswers
                userAnswers[Array.IndexOf(questions, question)] = Console.ReadLine();
                //Check if user answer is right (I.E. equal to right answer)
                if (userAnswers[Array.IndexOf(questions, question)] == rightanswers[Array.IndexOf(questions, question)])
                {
                    score++;
                }
                //Next Question
                if(Array.IndexOf(questions, question) != questions.Length - 1)
                {
                Console.WriteLine("Question Suivante...");
                Console.ReadKey();
                }
            }
            //Display score
            Console.Clear();
            Console.WriteLine($"Quiz Terminé !\nScore : {score}");
            return userAnswers;
        }
        public static void Play()
        {
            /*TODO: Once merged uncomment this
            //Get Quiz object from jsconfig1
            Quiz quiz = GetJson();
            */

            //Gameloop:
            string[] userAnswers = AskQuestions(GetQuestions(), GetRightAnswers());

            /* TODO: Once merged, uncomment this
            //Set user answers to Quiz Object
            quiz.userAnswers = userAnswers;
            */

            
            /*TODO: Once merged uncomment this
            //Add score to admin stats
            int tryNumber = Convert.ToInt32(quiz.Data.Try);
            tryNumber ++;
            quiz.Data.Try = Convert.ToString(quiz.Data.Try);
            */

            /*TODO: Once merged, uncomment this
            //save user answers to jsconfig1
            JsonFileManager.SetJson(blablaballbalblablalblabla)
            */

            //proposer de rejour(r) ou de retourner au menu(q)
        }
    }
}
