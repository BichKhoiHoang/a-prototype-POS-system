using System;
using System.Collections.Generic;

using nsDB;
using nsCustomer;
using Utils;

namespace nsCustomerDB {
	class CustomerDB : DB {
		const int DELIVERY_COST = 20;
		const int LOYALTY_POINTS_BATCH = 200;
		const int LOYALTY_POINTS_CASH_BACK = 20;
		static List<Customer> customers = new List<Customer>();

		public void Add(string email, string name, string number, string address) {
			customers.Add(new Customer(email, name, number, address, customers.Count));
		}

		public static string returnCustomerName(int customerID) {
			if (customerID >= customers.Count) {
				return "Invalid customer ID!";
			} else {
				return customers[customerID].name;
			}
		}

		public int ExecuteSale(int customerID, bool delivery, bool spendLoyalty, int amountDue) {
			Console.WriteLine($"Due amount so far: ${amountDue}");
			Console.WriteLine();
			if (customerID < 0) {
				Console.WriteLine("Neither delivery nor loyalty program was applied!");
				Console.WriteLine();
				Console.WriteLine($"Final due amount: ${amountDue}");
				Console.WriteLine();
				return amountDue;
			} else {
				if (spendLoyalty) {
					int times = customers[customerID].loyaltyPoints / LOYALTY_POINTS_BATCH;
					customers[customerID].loyaltyPoints -= times * LOYALTY_POINTS_BATCH;
					amountDue -= times * LOYALTY_POINTS_CASH_BACK;
					Console.WriteLine("Loyalty program applied:");
					Console.WriteLine($"--- Number of times: {times} times");
					Console.WriteLine($"--- Amount saved: ${times * LOYALTY_POINTS_CASH_BACK}");
					Console.WriteLine($"--- New amount due: ${amountDue}");
					Console.WriteLine();
				}
				if (delivery) {
					amountDue += DELIVERY_COST;
					Console.WriteLine("The order will be delivered:");
					Console.WriteLine($"--- Delivery address: {customers[customerID].address}");
					Console.WriteLine($"--- Delivery fee: ${DELIVERY_COST}");
					Console.WriteLine($"--- New amount due: ${amountDue}");
					Console.WriteLine();
				}
				customers[customerID].loyaltyPoints += amountDue;
				Console.WriteLine($"Final due amount: ${amountDue}");
				Console.WriteLine();
				return amountDue;
			}
		}

		public override void DisplayAll() {
			Console.WriteLine("___ ALL DATA IN THE CUSTOMER DATABASE ___");
			Console.WriteLine();
			for(int i = 0; i < customers.Count; i++) {
				Console.WriteLine($"Customer ID: {customers[i].ID}");
				Console.WriteLine($"--- Email: {customers[i].email}");
				Console.WriteLine($"--- Number: {customers[i].number}");
				Console.WriteLine($"--- Address: {customers[i].address}");
				Console.WriteLine($"--- Loyalty points: {customers[i].loyaltyPoints}");
				Console.WriteLine();
			}
			decor.PrintHorizontalDivider();
		}
	}
}