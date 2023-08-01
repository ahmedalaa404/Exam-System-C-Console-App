using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System_C__Console_App
{
	public abstract class QuestionsBase
	{
		// Header Question
		public abstract string Header { get; }

		// must Have Body Of Q 
		protected string body;
		public string Body
		{
			get { return body; }
			set { body = value; }
		}



		protected double Mark;
		public double mark
		{
			get { return Mark; }
			set { Mark = value; }
		}
		Answers[] AnswerList;
		public Answers[] answerList
		{
			get { return AnswerList; }
			set
			{
				AnswerList = value;
			}
		}
		private Answers RightAnswer;
		public Answers rightAnswer
		{
			get { return RightAnswer; }
			set { RightAnswer = value; }
		}

		public Answers this[int id]
		{
			get
			{
				for (int i = 0; i < AnswerList.Length; i++)
				{
					if (AnswerList[i].Answer_Id == id)
						return AnswerList[i];
				}
				return new Answers();
			}

		}


		public Answers this[string Text]
		{
			get
			{
				for (int i = 0; i < AnswerList.Length; i++)
				{
					if (AnswerList[i].AnswerText == Text)
						return AnswerList[i];
				}
				return new Answers();
			}
		}

		public QuestionsBase(string _Body, double _Marks)
		{
			Body = _Body;
			mark = _Marks;

		}



        public Answers UserAnswer{ get; set; }


        public QuestionsBase()
        {
			UserAnswer=new Answers();
			rightAnswer = new Answers();

		}

		public override string ToString()
		{
			return $"{Header} \t : {mark} \n---------------- \n  {Body} ";
		}

		public abstract void AddQuestion();





	}





	// and mark of Q



}

