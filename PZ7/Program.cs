using PZ7;

Store store = new Store();
Customer customer1 = new Customer("Иван");
Customer customer2 = new Customer("Мария");

store.RegisterObserver(customer1);
store.RegisterObserver(customer2);

store.AddDiscount("10% ни на что");
store.AddDiscount("2 товара по цене 3х!!!");

store.RemoveObserver(customer2);

store.AddDiscount("Спортивные товары есть xD");
