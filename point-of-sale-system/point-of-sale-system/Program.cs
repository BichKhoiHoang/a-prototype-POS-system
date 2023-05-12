using System;

using nsStore;

class Program {
    static void Main(string[] args) {
        // 1. Initialize a new store, with necessary databases
        Store store = new Store();

        // 2. Register new staff member
        store.StaffDB.Add(
            name: "Tony Stark",
            username: "ironman",
            password: "i am iron man",
            isAdmin: true
        );

        // 3. Staff member logins with username and password
        string staffUsername = "ironman";
        string password = "i am iron man";
        if (store.StaffDB.Login(staffUsername, password)) {

            // 4. Register new customer
            store.CustomerDB.Add(
                email: "khoituan@google.com",
                name: "Khoi N Tuan",
                number: "+61 1412 2907",
                address: "Google HQ @ Mountain View, California, United States"
            );

            // 5. Register new products
            store.ProductDB.Add(
                name: "Mark L",
                price: 240,
                quantity: 100
            );
            store.ProductDB.Add(
                name: "Hulkbuster",
                price: 300,
                quantity: 100
            );

            // 6.1 Khoi N Tuan buys 15 Mark L suits
            store.ExecuteSale(
                productID: 0,
                quantity: 15,
                staffUsername: staffUsername
                // customerID: 0
            );
            // 6.2 Khoi N Tuan buys 10 Hulkbuster suits, with delivery and loyalty points applied
            store.ExecuteSale(
                productID: 1,
                quantity: 10,
                staffUsername: staffUsername,
                customerID: 0,
                delivery: true,
                spendLoyalty: true
            );

            // 7. Display information in databases
            store.CustomerDB.DisplayAll();
            store.ProductDB.DisplayAll();
            store.StaffDB.DisplayAll();
            store.SaleDB.DisplayAll();
        } else {
            Console.WriteLine("Wrong credentials!");
        }
    }
}

