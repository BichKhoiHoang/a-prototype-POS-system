using System;
using System.Collections.Generic;

using nsDB;
using nsStaff;
using Utils;

namespace nsStaffDB {
	class StaffDB : DB {
		static List<Staff> staffs = new List<Staff>();
		public void Add(string name, string username, string password, bool isAdmin = false) {
			staffs.Add(new Staff(name, username, password, staffs.Count, isAdmin));
		}

		public bool Login(string staffUsername, string password) {
			for (int i = 0; i < staffs.Count; i++) {
				if (staffs[i].username == staffUsername && staffs[i].password == password) {
					Console.WriteLine("Login successfully:");
					Console.WriteLine($"--- Username: {staffUsername}");
					if (staffs[i].isAdmin) {
						Console.WriteLine($"--- Role: Administrative staff");
					} else {
						Console.WriteLine($"--- Role: Sales staff");
					}
					Console.WriteLine();
					return true;
				}
			}
			return false;
		}

		public static string returnStaffName(string staffUsername) {
			for (int i = 0; i < staffs.Count; i++) {
				if (staffs[i].username == staffUsername) {
					return staffs[i].name;
				}
			}
			return "Invalid staff username";
		}
		public override void DisplayAll() {
			Console.WriteLine("___ ALL DATA IN THE STAFF DATABASE ___");
			Console.WriteLine();
			for(int i = 0; i < staffs.Count; i++) {
				Console.WriteLine($"Staff ID: {staffs[i].ID}");
				Console.WriteLine($"--- Staff name: {staffs[i].name}");
				Console.WriteLine($"--- Username: {staffs[i].username}");
				Console.WriteLine($"--- Password: {staffs[i].password}");
				Console.WriteLine();
			}
			decor.PrintHorizontalDivider();
		}
	}
}
