using System;
using System.Data;
using System.IO;
using SQLite;

namespace ResponsibleAging
{
	[Table("ToDoTasks")]
	public class ToDoTasks
	{
		[PrimaryKey,AutoIncrement,Column("_Id")]
		public int Id { get; set; }

		[MaxLength(50)]

		public string Task { get; set; }

		public double HR { get; set; }

		public double Distance { get; set; }

		public int Dosage { get; set; }

		public String Medication { get; set; }

		public string FeedBack { get; set; }
	}
}