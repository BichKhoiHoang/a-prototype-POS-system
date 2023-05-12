using System;

namespace nsProduct {
	class Product {
		public string name; // ! must be unique
		public int price;
		public int quantity;
		public int ID; // index from 0

		public Product(string name, int price, int quantity, int ID) {
			this.name = name;
			this.price = price;
			this.quantity = quantity;
			this.ID = ID;

			Console.WriteLine("New product added:");
			Console.WriteLine($"--- Product name: {name}");
			Console.WriteLine($"--- Price: ${price}");
			Console.WriteLine($"--- Quantity: {quantity}");
			Console.WriteLine($"--- Product ID: {ID}");
			Console.WriteLine();
		}
	}
}