using System;
using System.Collections.Generic;

using nsDB;
using nsSale;
using nsStaffDB;
using nsProductDB;
using nsCustomerDB;
using Utils;

namespace nsSaleDB {
	class SaleDB : DB {
		List<Sale> sales = new List<Sale>();
		public void Add(int productID, int quantity, string staffUsername, int amountDue, int customerID) {
			string staffName = StaffDB.returnStaffName(staffUsername);
			string productName = ProductDB.returnProductName(productID);
			string customerName;
			if (customerID < 0) {
				customerName = "INFORMATION_NOT_PROVIDED";
			} else {
				customerName = CustomerDB.returnCustomerName(customerID);
			}
			sales.Add(new Sale(staffName, productName, quantity, amountDue, customerName, sales.Count));
		}

		public override void DisplayAll() {
			Console.WriteLine("___ ALL DATA IN THE SALE DATABASE ___");
			Console.WriteLine();
			for(int i = 0; i < sales.Count; i++) {
				Console.WriteLine($"SALE ID: {sales[i].ID}");
				Console.WriteLine($"--- Staff name: {sales[i].staffName}");
				Console.WriteLine($"--- Product name: {sales[i].productName}");
				Console.WriteLine($"--- Quantity: {sales[i].quantity}");
				Console.WriteLine($"--- Total amount: {sales[i].amountDue}");
				Console.WriteLine($"--- Date and time of sale: {sales[i].dateTimeOfSale}");
				Console.WriteLine($"--- Customer name: {sales[i].customerName}");
				Console.WriteLine();
			}
			decor.PrintHorizontalDivider();
		}
	}
}