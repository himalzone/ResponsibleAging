using System;
using System.Data;
using System.IO;
using SQLite;

namespace ResponsibleAging
{
	public class DBRepository
	{
		
			//code to create the DataBase

			public string CreateDB()
			{
				var output = "";
				//output += "DataBase Loaded";
				string dbPath = Path.Combine (Environment.GetFolderPath
					(Environment.SpecialFolder.Personal), "ormdeo.db3");
				var db = new SQLiteConnection (dbPath);
				output += "Hello";
				return output;
			}

		//code to create the Table
		public string CreateTable()
		{
			try {
				string dbPath = Path.Combine (Environment.GetFolderPath
					(Environment.SpecialFolder.Personal), "ormdeo.db3");
				var db = new SQLiteConnection (dbPath);
				db.CreateTable<ToDoTasks> ();
				String result = "Welcome TO Resposible Aging";
				return result;
			} catch (Exception ex) {
				return "Error : " + ex.Message;
			}
		}

		//code to insert a record

		public string InsertRecord(string medication)
		{
			try
			{
				string dbPath = Path.Combine (Environment.GetFolderPath
					(Environment.SpecialFolder.Personal), "ormdeo.db3");
				var db = new SQLiteConnection (dbPath);

				ToDoTasks item = new ToDoTasks();
				item.Medication = medication;
				db.Insert (item);
				return "Record Added..";
			}
			catch (Exception ex)
			{
				return "Error : " + ex.Message;
			}
		}

		// code to retrieve all the record

		public string GetAllRecords()
		{
			string dbPath = Path.Combine (Environment.GetFolderPath
				(Environment.SpecialFolder.Personal), "ormdeo.db3");
			var db = new SQLiteConnection (dbPath);

			string output = "";
			output += "";
			var table = db.Table<ToDoTasks>();

			foreach(var item in table)
			{
				output += "\n" + item.Medication;
			}
			return output;
		}

		//code to retrieve specific record using ORM

		public string GetTaskById(int id)
		{

			string dbPath = Path.Combine (Environment.GetFolderPath
				(Environment.SpecialFolder.Personal), "ormdeo.db3");
			var db = new SQLiteConnection (dbPath);

			var item = db.Get<ToDoTasks> (id);
			return item.Task;
		}

		//code to update the recod using ORM
		public string updateRecord(int id, string task)
		{
			string dbPath = Path.Combine (Environment.GetFolderPath
				(Environment.SpecialFolder.Personal), "ormdeo.db3");
			var db = new SQLiteConnection (dbPath);

			var item = db.Get<ToDoTasks> (id);
			item.Task = task;
			db.Update (item);

			return "Record Updated";
		}
		}
	}


