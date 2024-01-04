using ClassMetotDemo;
Customer customer1 = new Customer()
{
    Id = 1,
    FirstName = "Özcan",
    LastName = "Yalçın"
};

Customer customer2 = new Customer()
{
    Id = 2,
    FirstName = "Ercan",
    LastName = "Demir"
};
Customer[]customers=new Customer[] {customer1, customer2};  
CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);
Console.WriteLine();
customerManager.Delete(customer1);
customerManager.Delete(customer2);
Console.WriteLine();
customerManager.GetList(customers);