using System;

namespace nsStaff {
	class Staff {
		public string name;
		public string username;
		public string password;
		public int ID; // index from 0
		public bool isAdmin;

		public Staff(string name, string username, string password, int ID, bool isAdmin = false) {
			this.name = name;
			this.username = username;
			this.password = password;
			this.ID = ID;
			this.isAdmin = isAdmin;

			Console.WriteLine("New staff added:");
			Console.WriteLine($"--- Staff name: {name}");
			Console.WriteLine($"--- Username: {username}");
			Console.WriteLine($"--- Password: {password}");
			Console.WriteLine($"--- Staff ID: {ID}");
			if (isAdmin) {
				Console.WriteLine($"--- Role: Administrative staff");
			} else {
				Console.WriteLine($"--- Role: Sales staff");
			}
			Console.WriteLine();

		}
	}
}