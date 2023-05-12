using System;

using Utils;

namespace nsSale {
	class Sale {
		public string staffName;
		public string productName;
		public int quantity;
		public int amountDue;
		public string dateTimeOfSale;
		public string customerName;
		public int ID;

		public Sale(string staffName, string productName, int quantity, int amountDue, string customerName, int ID) {
			this.staffName = staffName;
			this.productName = productName;
			this.quantity = quantity;
			this.amountDue = amountDue;
			this.dateTimeOfSale = time.GetCurrentDateTime();
			this.customerName = customerName;
			this.ID = ID;

			Console.WriteLine("New sale record added:");
			Console.WriteLine($"--- Staff name: {staffName}");
			Console.WriteLine($"--- Product name: {productName}");
			Console.WriteLine($"--- Quantity: {quantity}");
			Console.WriteLine($"--- Total amount: {amountDue}");
			Console.WriteLine($"--- Date and time of sale: {dateTimeOfSale}");
			Console.WriteLine($"--- Customer name: {customerName}");
			Console.WriteLine($"--- Sale ID: {ID}");

			Console.WriteLine();
		}
	}
}