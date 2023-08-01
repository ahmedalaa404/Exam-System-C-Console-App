using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System_C__Console_App
{
	public  class Answers
	{

		private string answerText;
		private int answer_Id;
        public string AnswerText 
		{

			get { return answerText; }
			set {  answerText=value; }
		}
        public int Answer_Id 
		{
			get { return answer_Id; }
			set { answer_Id = value; }
		}
        public Answers(string _AnswerText ,  int _AsnwerId)
		{
			answerText = AnswerText;
			answer_Id = _AsnwerId;
            Console.WriteLine();
        }

        public Answers()
        {
            
        }
    }
}
