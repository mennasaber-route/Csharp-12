namespace Assignment_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // *******   OOP 05 – Smart Delivery Management System **********
            //    Part 01 : Theoretical Questions   //

            #region  Question 1 (object copying)

            // a) What happens when you assign one object variable to another object variable?
            // when you assign one object variable to another object variable, both variables will reference the same object in heap.


            //  b) Does assigning one object to another create a new object? Explain.
            // no , assigning one object to another does not create a new object. It simply copies the
            // reference of the original object to the new variable, so both variables point to the same object in memory.


            // c) What is the difference between copying an object and copying its reference?
            // copying an object creates anew independent object in memory , while copying its reference makes both variables point to the same object in memory.
            // Changes made to one variable will affect the other when copying reference, but not when copying an object.


            #endregion


            #region  Question 2 (Shallow Copy vs Deep Copy)

            // a) What is a Shallow Copy?
            // create anew object in heap and copies the values of the original object's
            // fields to the new object ,but objects point to the same nested objects.


            // b) What is a Deep Copy?
            // create a new object in heap and copies all the fields and nested objects to the new object.
            // but the new object is independent of the original object.

            // c) What happens to reference-type members when a Shallow Copy is created?
            // still point to the same object - when a shallow copy is created, the reference-type members of the original
            // object are copied to the new object, but both objects point to the same nested objects in memory.

            // d) What happens to reference-type members when a Deep Copy is created?
            // we create a new object in heap and will not point to the same object - when a deep copy is created,
            // the reference-type members of the original object are copied to the new object, and both objects point to different nested objects in memory.

            // e) Give one situation where Deep Copy would be safer than Shallow Copy.
            // Deep Copy would be safer than Shallow Copy when you want to create a new object that is independent
            // of the original object, and you want to avoid effects caused by changes to the original
            // object's nested objects. For example, if you have a class that contains a list of items,
            // and you want to create a copy of that class without affecting the original list, you would use Deep Copy.
            // or if i want to change the nested object of original without affecting the copied object.

            #endregion


            #region Question Part 02 : Practical
            //   Part 02 : Practical   //

            DeliveryAddress address = new DeliveryAddress("Cairo", "Nasr City", 10);

            StandardShipment standardShipment = new StandardShipment("SH001", "Laptop", 3, 80, address);

            Console.WriteLine("==========================================");
            Console.WriteLine("Object Copying");
            Console.WriteLine("==========================================");

            Shipment shipment1 = standardShipment;
            Shipment shipment2 = shipment1;
            Console.WriteLine("Original Shipment  : " + shipment1.TrackingCode);
            Console.WriteLine("Copy Shipment  : " + shipment2.TrackingCode);
            Console.WriteLine();
            Console.WriteLine("Same Object : " + ReferenceEquals(shipment1, shipment2));


            Shipment shallowcopy = shipment1.ShallowCopy();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Shallow Copy");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Original Shipment Address : " + shipment1.DeliveryAddress.City);
            Console.WriteLine("Copied Shipment Address   : " + shallowcopy.DeliveryAddress.City);
            Console.WriteLine("Changing copied shipment address... ");
            shallowcopy.DeliveryAddress.City = "Giza";
            Console.WriteLine("Original Shipment Address : " + shipment1.DeliveryAddress.City);
            Console.WriteLine("Copied Shipment Address   : " + shallowcopy.DeliveryAddress.City);
            Console.WriteLine("Same DeliveryAddress Object : " + ReferenceEquals(shipment1.DeliveryAddress.City, shallowcopy.DeliveryAddress.City));


            Shipment deepcopy = shipment1.DeepCopy();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Deep Copy");
            Console.WriteLine("------------------------------------------");
            deepcopy.DeliveryAddress.City = "Cairo";
            shipment1.DeliveryAddress.City = "Cairo";
            Console.WriteLine("Original Shipment Address : " + shipment1.DeliveryAddress.City);
            Console.WriteLine("Copied Shipment Address   : " + deepcopy.DeliveryAddress.City);
            Console.WriteLine("Changing copied shipment address... ");
            deepcopy.DeliveryAddress.City = "Giza";
            Console.WriteLine($"Original Shipment Address : {shipment1.DeliveryAddress.City}");
            Console.WriteLine($"Copied Shipment Address   : {deepcopy.DeliveryAddress.City}");
            Console.WriteLine("Same DeliveryAddress Object : " + ReferenceEquals(shipment1.DeliveryAddress.City, deepcopy.DeliveryAddress.City));


            #endregion

        }
    }
}
