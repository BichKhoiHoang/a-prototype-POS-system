using System;

namespace nsCustomer {
	class Customer {
		public string email;
		public string name;
		public string number;
		public string address;
		public int ID; // indexed from 0
		public int loyaltyPoints;

		public Customer(string email, string name, string number, string address, int ID) {
			this.email = email;
			this.name = name;
			this.number = number;
			this.address = address;
			this.ID = ID;
			this.loyaltyPoints = 0;

			Console.WriteLine("New customer added:");
			Console.WriteLine($"--- Customer name: {name}");
			Console.WriteLine($"--- Email: {email}");
			Console.WriteLine($"--- Number: {number}");
			Console.WriteLine($"--- Address: {address}");
			Console.WriteLine($"--- Customer ID: {ID}");
			Console.WriteLine($"--- Loyalty points: {loyaltyPoints}");
			Console.WriteLine();
		}
	}
}