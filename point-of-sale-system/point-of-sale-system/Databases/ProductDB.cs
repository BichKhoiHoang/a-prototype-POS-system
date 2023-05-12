using System;
using System.Collections.Generic;

using nsDB;
using nsProduct;
using Utils;

namespace nsProductDB {
	class ProductDB : DB {
		static List<Product> products = new List<Product>();
		public void Add(string name, int price, int quantity) {
			products.Add(new Product(name, price, quantity, products.Count));
		}

		public int ExecuteSale(int productID, int quantity) {
			// TODO: Add product quantity logic check
			products[productID].quantity -= quantity;
			Console.WriteLine("ProductDB updated:");
			Console.WriteLine($"--- Product name: {products[productID].name}");
			Console.WriteLine($"--- Updated quantity: {products[productID].quantity}");
			Console.WriteLine();
			return products[productID].price * quantity;
		}

		public static string returnProductName(int productID) {
			for (int i = 0; i < products.Count; i++) {
				if (products[i].ID == productID) {
					return products[i].name;
				}
			}
			return "Invalid product ID!";
		}

		public override void DisplayAll() {
			Console.WriteLine("___ ALL DATA IN THE PRODUCT DATABASE ___");
			Console.WriteLine();
			for(int i = 0; i < products.Count; i++) {
				Console.WriteLine($"Product ID: {products[i].ID}");
				Console.WriteLine($"--- Product name: {products[i].name}");
				Console.WriteLine($"--- Price: ${products[i].price}");
				Console.WriteLine($"--- Quantity: {products[i].quantity}");
				Console.WriteLine();
			}
			decor.PrintHorizontalDivider();
		}
	}
}