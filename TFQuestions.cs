using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System_C__Console_App
{
	public class TFQuestions : QuestionsBase
	{
		public override string Header => "True Or False Questions ";
        public TFQuestions()
        {
			answerList = new Answers[2]
			{
			 answerList[0]=new Answers {AnswerText="false",Answer_Id=0} ,
			answerList[1]=new Answers {AnswerText="true",Answer_Id=1}  ,
			};

        }

        public override void AddQuestion()
		{
            Console.WriteLine($"{Header}");

            Console.WriteLine("Enter Body OF Questions ");
			body=Console.ReadLine();
			int marks;
			do
			{
                Console.WriteLine("Enter The marks OF Q");

            } while (!(int.TryParse(Console.ReadLine(), out marks)));

			Mark = marks;
			bool Flage=false;
			int RightAnswers;
			do
			{
                Console.WriteLine("Enter The Id Of Right Answer \n 1 - false \n 2 - true");
				Flage=int.TryParse(Console.ReadLine(), out RightAnswers);
				if (RightAnswers== 1 && RightAnswers ==2)
					Flage = true;


			} while (!Flage);
			rightAnswer.Answer_Id = RightAnswers;
			rightAnswer.AnswerText = answerList[RightAnswers - 1].AnswerText;
			Console.Clear();



		}


	}
}
