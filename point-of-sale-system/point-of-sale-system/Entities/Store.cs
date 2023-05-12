using System;

using nsCustomerDB;
using nsProductDB;
using nsSaleDB;
using nsStaffDB;
using Utils;

namespace nsStore {
	class Store {
		public CustomerDB CustomerDB;
		public ProductDB ProductDB;
		public SaleDB SaleDB;
		public StaffDB StaffDB;

		public Store() {
			Console.WriteLine("Store created!");
			this.CustomerDB = new CustomerDB();
			Console.WriteLine("--- CustomerDB created!");
			this.ProductDB = new ProductDB();
			Console.WriteLine("--- ProductDB created!");
			this.SaleDB = new SaleDB();
			Console.WriteLine("--- SaleDB created!");
			this.StaffDB = new StaffDB();
			Console.WriteLine("--- StaffDB created!");
			Console.WriteLine();
		}

		public void ExecuteSale(int productID, int quantity, string staffUsername, int customerID = -999, bool delivery = false, bool spendLoyalty = false) {
			decor.PrintHorizontalDivider();
			Console.WriteLine("Executing sale...");
			Console.WriteLine();

			// Update ProductDB: update stock level
			int amountDue = ProductDB.ExecuteSale(productID, quantity); // amount to pay before delivery & loyaltyPoints

			// Update CustomerDB: Update loyalty points
			amountDue = CustomerDB.ExecuteSale(customerID, delivery, spendLoyalty, amountDue);

			// Update SaleDB: new sale record
			SaleDB.Add(productID, quantity, staffUsername, amountDue, customerID);

			Console.WriteLine("Executed sale successfully! Ending...");
			decor.PrintHorizontalDivider();
		}
	}
}