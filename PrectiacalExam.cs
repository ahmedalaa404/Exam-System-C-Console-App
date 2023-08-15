using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System_C__Console_App
{
	public class PrectiacalExam : Exam
	{

		public PrectiacalExam(int time, int NumberQ) : base(time, NumberQ)
		{

		}
		public override void CreateExam()
		{
			ListQuestions = new McqQuestion[NumbrtOfQuestions];
			for (int i = 0; i < ListQuestions.Length; i++)
			{
				ListQuestions[i]=new McqQuestion();
				ListQuestions[i].AddQuestion();
				Console.Clear();
			}


		}

		public override void ShowExam()
		{
			for (int i = 0; i < ListQuestions.Length; i++)
			{
				Console.WriteLine(ListQuestions[i]+"\t" );
				for (int n = 0; n < ListQuestions[i].answerList.Length; n++)
				{
<<<<<<< HEAD
                    Console.WriteLine((n+1)+"--"+ ListQuestions[i].answerList[n].AnswerText+"\n");
=======
                    Console.WriteLine((n+1)+"--"+ ListQuestions[i].answerList[n]+"\n");
>>>>>>> d144259c6aa89acd50017574fc778a611fdf0646
                }
                Console.WriteLine("--------------------------");
				int UserAnswerId;
				bool Flag;
				do
				{

					Flag = int.TryParse(Console.ReadLine(), out UserAnswerId);

					if (UserAnswerId > 0 && UserAnswerId < 5) 
						Flag=false;

				} while (Flag);
				ListQuestions[i].UserAnswer.Answer_Id = UserAnswerId - 1;

				ListQuestions[i].UserAnswer.AnswerText = ListQuestions[i].answerList[UserAnswerId - 1].AnswerText;

                Console.WriteLine("Right Answers ");
				foreach (var item in ListQuestions)
				{
                    Console.WriteLine(item);
<<<<<<< HEAD
                    Console.WriteLine($" \t Right Answers Is = {item.rightAnswer.AnswerText}");
=======
                    Console.WriteLine($" \t Right Answers Is = {item.rightAnswer}");
>>>>>>> d144259c6aa89acd50017574fc778a611fdf0646
                }
            }
		}
	}
}
