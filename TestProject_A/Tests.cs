using Project_partA_Sylenok;

namespace TestProject_A
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
        public void AddProductToInventory_ShouldAddProductToInventory()
        {
            // Arrange
            Store store = new Store("TestStore", "TestAddress");
            Product product = new Product("TestProduct", 10.99m);
            int quantity = 5;

            // Act
            store.AddProductToInventory(product, quantity);

            // Assert
            Assert.AreEqual(1, store.Inventory.Count);
            Assert.AreEqual(product, store.Inventory[0].Product);
            Assert.AreEqual(quantity, store.Inventory[0].Quantity);
        }

        [TestMethod]
        public void PrintInventory_ShouldPrintInventory()
        {
            // Arrange
            Store store = new Store("TestStore", "TestAddress");
            Product product1 = new Product("TestProduct1", 10.99m);
            Product product2 = new Product("TestProduct2", 15.99m);
            store.AddProductToInventory(product1, 5);
            store.AddProductToInventory(product2, 10);

            // Act
            
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            store.PrintInventory();

            // Assert
            string expectedOutput = $"Інвентар магазину 'TestStore':\r\n" +
                                   $"TestProduct1 - 5 одиниць, Статус: InStock\r\n" +
                                   $"TestProduct2 - 10 одиниць, Статус: InStock\r\n";
            Assert.AreEqual(expectedOutput, stringWriter.ToString());
        }


        [TestMethod]
        public void SupplyProductsToStore_ShouldAddProductsToStoreInventory()
        {
            // Arrange
            Store store = new Store("TestStore", "TestAddress");
            Supplier supplier = new Supplier("TestSupplier", "SupplierContact");

            List<ISellable> products = new List<ISellable>
            {
                new Product("Product1", 10.99m),
                new Product("Product2", 15.99m)
            };

            List<int> quantities = new List<int> { 5, 10 };

            // Act
            supplier.SupplyProductsToStore(store, products, quantities);

            // Assert
            Assert.AreEqual(2, store.Inventory.Count);

            Assert.AreEqual("Product1", store.Inventory[0].Product.Name);
            Assert.AreEqual(10.99m, store.Inventory[0].Product.Price);
            Assert.AreEqual(5, store.Inventory[0].Quantity);

            Assert.AreEqual("Product2", store.Inventory[1].Product.Name);
            Assert.AreEqual(15.99m, store.Inventory[1].Product.Price);
            Assert.AreEqual(10, store.Inventory[1].Quantity);
        }

        [TestMethod]
        public void SupplyProductsToStore_ShouldPrintSupplyMessage()
        {
            // Arrange
            Store store = new Store("TestStore", "TestAddress");
            Supplier supplier = new Supplier("TestSupplier", "SupplierContact");

            List<ISellable> products = new List<ISellable>
            {
                new Product("Product1", 10.99m),
                new Product("Product2", 15.99m)
            };

            List<int> quantities = new List<int> { 5, 10 };

            // Act
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                supplier.SupplyProductsToStore(store, products, quantities);

                // Assert
                string expectedOutput = "Товар 'Product1' (ціна: 10,99 ₴) у кількості 5 одиниць постачено до магазину 'TestStore'.\r\n" +
                                       "Товар 'Product2' (ціна: 15,99 ₴) у кількості 10 одиниць постачено до магазину 'TestStore'.\r\n";
                Assert.AreEqual(expectedOutput, stringWriter.ToString());
            }
        }
    }
}