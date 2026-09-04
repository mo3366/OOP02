using System.Threading.Channels;

namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region 1. Create a DeliveryAddress struct 
            //DeliveryAddress address1 = new DeliveryAddress("New York", "Main Street", 123);

            //DeliveryAddress address2 = address1;
            //address2.City = "Giza";
            //address2.Street = "Pyramids Street";
            //address2.BuildingNumber = 100;

            //Console.WriteLine("original address:");
            //Console.WriteLine(address1.GetFullAddress());

            //Console.WriteLine("\nCopied Address after modification:");
            //Console.WriteLine(address2.GetFullAddress());
            //#endregion

            //#region 6. In Main, build a Console Application
            //// a. Create a DeliveryCenter
            //DeliveryCenter center = new DeliveryCenter();

            //// b & c. Read data for three shipments
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"\nEnter Shipment {i + 1} Data");

            //    // Tracking Code
            //    Console.Write("Tracking Code: ");
            //    string trackingCode = Console.ReadLine();

            //    // Description
            //    Console.Write("Description: ");
            //    string description = Console.ReadLine();

            //    // Weight
            //    double weight;
            //    do
            //    {
            //        Console.Write("Weight: ");
            //    }
            //    while (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0);

            //    // Delivery Fee
            //    double deliveryFee;
            //    do
            //    {
            //        Console.Write("Delivery Fee: ");
            //    }
            //    while (!double.TryParse(Console.ReadLine(), out deliveryFee) || deliveryFee <= 0);

            //    // Destination
            //    Console.Write("City: ");
            //    string city = Console.ReadLine();

            //    Console.Write("Street: ");
            //    string street = Console.ReadLine();

            //    int buildingNumber;
            //    do
            //    {
            //        Console.Write("Building Number: ");
            //    }
            //    while (!int.TryParse(Console.ReadLine(), out buildingNumber) ||
            //           buildingNumber <= 0);

            //    DeliveryAddress address =
            //        new DeliveryAddress(city, street, buildingNumber);

            //    // Create Shipment
            //    Shipment shipment = new Shipment(
            //        trackingCode,
            //        description,
            //        weight,
            //        deliveryFee,
            //        address
            //    );

            //    // Add Shipment
            //    if (center.AddShipment(shipment))
            //    {
            //        Console.WriteLine("\nShipment added successfully.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nDelivery Center is full.");
            //    }
            //}

            //// d. Print the three shipments using integer indexer
            //Console.WriteLine("\n--- All Shipments ---");

            //for (int i = 0; i < 3; i++)
            //{
            //    Shipment shipment = center[i];

            //    Console.WriteLine($"--- Shipment {i + 1} ---");
            //    shipment.PrintShipment();
            //    Console.WriteLine();
            //}

            //// e. Ask user for tracking code
            //Console.Write("\nEnter a tracking code to search: ");
            //string searchCode = Console.ReadLine();

            //// f. Search using string indexer
            //Shipment foundShipment = center[searchCode];

            //// g. Print result
            //if (!string.IsNullOrWhiteSpace(foundShipment.TrackingCode))
            //{
            //    Console.WriteLine(
            //        $"Shipment Found: {foundShipment.TrackingCode} - " +
            //        $"{foundShipment.Description}"
            //    );

            //    foundShipment.PrintShipment();
            //}
            //else
            //{
            //    Console.WriteLine("Shipment not found.");
            //}

            //// h. Demonstrate DeliveryAddress struct copy behavior
            //Console.WriteLine("\n--- Struct Copy Test ---");

            //DeliveryAddress originalAddress =
            //    new DeliveryAddress("Cairo", "Tahrir Street", 15);

            //DeliveryAddress copiedAddress = originalAddress;

            //// Modify the copy
            //copiedAddress.City = "Giza";
            //copiedAddress.Street = "Makram Ebeid Street";
            //copiedAddress.BuildingNumber = 20;

            //Console.WriteLine(
            //    $"Original Address: {originalAddress.GetFullAddress()}"
            //);

            //Console.WriteLine(
            //    $"Copied Address: {copiedAddress.GetFullAddress()}"
            //);
            //#endregion


            #region OOP 02 -- Part 01 : Theoretical Questions
            //a) What is the difference between a class and a struct?
            // Answer: Classes are reference types and are allocated on the heap
            // while structs are value types and are allocated on the stack.
            // Classes support inheritance , while structs do not.
            // Classes have a default constructor that initializes all fields to their default values, while structs have a default constructor that does not initialize fields.
            //class Default Constructor Provided if none defined (implicit parameterless constructor) ,
            //struct Default Constructor Always exists (parameterless constructor)..

            //b) Why are classes more suitable than structs for large applications?
            // Answer: Classes are more suitable for large applications because they support inheritance and polymorphism,
            // which allow for better code organization and reusability. Additionally, classes can have complex behavior
            // and state management, making them more appropriate for handling the complexity of large-scale applications.
            #endregion

            #region Part 01 : Theoretical Questions - Question 2
            //a) Which class is the parent class?
            // Answer: shipment is the parent class

            //b) Which class is the child class?
            // Answer: ExpressShipment is the child class

            //c) What members are inherited by ExpressShipment?
            // Answer: TrackingCode (property)

            //d) Why is inheritance better than duplicating the same code in multiple classes?
            // Answer:
            //1 Code Reusability: Avoids writing the same properties or methods repeatedly across multiple related classes.
            //2 Maintainability: Changes made to common logic in the parent class automatically propagate to all child classes.
            //3 Extensibility & Polymorphism: Allows creating specialized classes that build upon existing logic without modifying the base code.
            #endregion

            #region OOP 03 -- Part 01 : Theoretical Questions
            //Q1 Overloading, Overriding, and Binding

            //a) What is the difference between Method Overloading and Method Overriding?
            // Answer: Method Overloading is Allows a class to have multiple methods with the same name but different Parameters..
            // Method Overriding is Allows a derived class to provide a specific implementation of a method that is already defined in its base class

            //b)  What is the difference between Static Binding and Dynamic Binding?
            // Answer: Static Binding (also known as early binding) occurs at compile time - faster - where the method to be invoked is determined based on the reference type.
            // Dynamic Binding (also known as late binding) occurs at runtime, where the method to be invoked is determined based on the actual object type.


            //Q2  Sealed Classes and Methods

            //a)  What is the purpose of the sealed keyword when applied to a class?
            // Answer: A sealed class is a class that cannot be inherited. It stops the inheritance chain completely.

            //b)  What is the difference between a sealed class and a sealed method?
            // Answer: A sealed class cannot be inherited, while a sealed method can be inherited but cannot be overridden in derived classes.
            //sealed class: A sealed class is a class that cannot be inherited. It stops the inheritance chain completely.
            //Sealed Method: A method can be sealed inside a derived class to prevent further overriding down the chain.

            //c)  Can a sealed method be overridden? Why?
            // Answer: No, a sealed method cannot be overridden. Sealing a method prevents any further overriding in derived classes, ensuring that the implementation remains unchanged in the inheritance hierarchy.

            #endregion

            #region 5. In Main 
            //Console.Write("Enter Delivery Center Name: ");
            //string centerName = Console.ReadLine();

            //DeliveryCenter center = new DeliveryCenter(centerName);

            //// =========================
            //// Standard Shipment
            //// =========================

            //Console.WriteLine("\nEnter Standard Shipment Data");

            //Console.Write("Tracking Code: ");
            //string trackingCode = Console.ReadLine();

            //Console.Write("Description: ");
            //string description = Console.ReadLine();

            //Console.Write("Weight: ");
            //decimal weight = decimal.Parse(Console.ReadLine());

            //Console.Write("Delivery Fee: ");
            //decimal deliveryFee = decimal.Parse(Console.ReadLine());

            //Console.Write("City: ");
            //string city = Console.ReadLine();

            //Console.Write("Street: ");
            //string street = Console.ReadLine();

            //Console.Write("Building Number: ");
            //int buildingNumber = int.Parse(Console.ReadLine());

            //DeliveryAddress address =
            //    new DeliveryAddress(city, street, buildingNumber);

            //StandardShipment standardShipment =
            //    new StandardShipment(
            //        trackingCode,
            //        description,
            //        weight,
            //        deliveryFee,
            //        address
            //    );

            //if (center.AddShipment(standardShipment))
            //    Console.WriteLine("Shipment Added Successfully.");


            //// =========================
            //// Express Shipment
            //// =========================

            //Console.WriteLine("\nEnter Express Shipment Data");

            //Console.Write("Tracking Code: ");
            //trackingCode = Console.ReadLine();

            //Console.Write("Description: ");
            //description = Console.ReadLine();

            //Console.Write("Weight: ");
            //weight = decimal.Parse(Console.ReadLine());

            //Console.Write("Delivery Fee: ");
            //deliveryFee = decimal.Parse(Console.ReadLine());

            //Console.Write("Extra Fee: ");
            //decimal extraFee = decimal.Parse(Console.ReadLine());

            //Console.Write("City: ");
            //city = Console.ReadLine();

            //Console.Write("Street: ");
            //street = Console.ReadLine();

            //Console.Write("Building Number: ");
            //buildingNumber = int.Parse(Console.ReadLine());

            //address = new DeliveryAddress(
            //    city,
            //    street,
            //    buildingNumber
            //);

            //ExpressShipment expressShipment =
            //    new ExpressShipment(
            //        trackingCode,
            //        description,
            //        weight,
            //        deliveryFee,
            //        address,
            //        extraFee
            //    );

            //if (center.AddShipment(expressShipment))
            //    Console.WriteLine("Shipment Added Successfully.");


            //// =========================
            //// International Shipment
            //// =========================

            //Console.WriteLine("\nEnter International Shipment Data");

            //Console.Write("Tracking Code: ");
            //trackingCode = Console.ReadLine();

            //Console.Write("Description: ");
            //description = Console.ReadLine();

            //Console.Write("Weight: ");
            //weight = decimal.Parse(Console.ReadLine());

            //Console.Write("Delivery Fee: ");
            //deliveryFee = decimal.Parse(Console.ReadLine());

            //Console.Write("City: ");
            //city = Console.ReadLine();

            //Console.Write("Street: ");
            //street = Console.ReadLine();

            //Console.Write("Building Number: ");
            //buildingNumber = int.Parse(Console.ReadLine());

            //Console.Write("Destination Country: ");
            //string destinationCountry = Console.ReadLine();

            //Console.Write("Customs Fee: ");
            //decimal customsFee = decimal.Parse(Console.ReadLine());

            //address = new DeliveryAddress(
            //    city,
            //    street,
            //    buildingNumber
            //);

            //InternationalShipment internationalShipment =
            //    new InternationalShipment(
            //        trackingCode,
            //        description,
            //        weight,
            //        deliveryFee,
            //        address,
            //        destinationCountry,
            //        customsFee
            //    );

            //if (center.AddShipment(internationalShipment))
            //    Console.WriteLine("Shipment Added Successfully.");


            //// =========================
            //// Print All Shipments
            //// =========================

            //center.PrintAllShipments();


            //// =========================
            //// Search Shipment
            //// =========================

            //Console.Write("\nEnter Tracking Code to Search: ");
            //string searchCode = Console.ReadLine();

            //Shipment foundShipment = center[searchCode];

            //if (foundShipment != null)
            //{
            //    Console.WriteLine(
            //        $"Shipment Found: {foundShipment.TrackingCode} - " +
            //        $"{foundShipment.Description}"
            //    );
            //}
            //else
            //{
            //    Console.WriteLine("Shipment not found.");
            //}


            //// =========================
            //// Remove Shipment
            //// =========================

            //Console.Write("\nEnter Tracking Code to Remove: ");
            //string removeCode = Console.ReadLine();

            //if (center.RemoveShipment(removeCode))
            //{
            //    Console.WriteLine("Shipment Removed Successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Shipment not found.");
            //}


            //// =========================
            //// Remaining Shipments
            //// =========================

            //Console.WriteLine("\n========================================");
            //Console.WriteLine("Remaining Shipments");
            //Console.WriteLine("========================================");

            //for (int i = 0; i < 20; i++)
            //{
            //    Shipment shipment = center[i];

            //    if (shipment != null)
            //    {
            //        Console.WriteLine(
            //            $"Tracking Code: {shipment.TrackingCode}"
            //        );
            //    }
            //}
            #endregion

            #region main oop03
            //            //a. Create Driver
            //            Driver driver = new Driver(1,  "Ahmed Mohamed",  "01000000000" );

            //            //b. Create DeliveryCenter
            //            DeliveryCenter center = new DeliveryCenter("Cairo Center");

            //            //c. Assign Driver
            //            center.Driver = driver;

            //            //d/e/f. Create Shipments
            //            StandardShipment standardShipment =
            //    new StandardShipment(
            //        "SH001",
            //        "Laptop",
            //        3,
            //        80,
            //        new DeliveryAddress("Cairo", "Tahrir Street", 15)
            //    );

            //            ExpressShipment expressShipment =
            //                new ExpressShipment(
            //                    "SH002",
            //                    "Mobile Phone",
            //                    2,
            //                    60,
            //                    new DeliveryAddress("Cairo", "Nasr Street", 20),
            //                    30
            //                );

            //            InternationalShipment internationalShipment =
            //                new InternationalShipment(
            //                    "SH003",
            //                    "Television",
            //                    8,
            //                    120,
            //                    new DeliveryAddress("Cairo", "Main Street", 10),
            //                    "Germany",
            //                    100
            //                );

            //            //g. Add them
            //            center.AddShipment(standardShipment);
            //            center.AddShipment(expressShipment);
            //            center.AddShipment(internationalShipment);

            //            //h. Print All
            //            center.PrintAllShipments();

            //            //i. DeliveryHelper
            //            Console.WriteLine("\n==========================================");
            //            Console.WriteLine("Printing Using DeliveryHelper...");
            //            Console.WriteLine("==========================================");

            //            DeliveryHelper.PrintShipmentDetails(standardShipment);
            //            DeliveryHelper.PrintShipmentDetails(expressShipment);
            //            DeliveryHelper.PrintShipmentDetails(internationalShipment);

            //            //j. Test UpdateWeight Overloading
            //            Console.WriteLine("\n==========================================");
            //            Console.WriteLine("Updating Weight...");
            //            Console.WriteLine("==========================================");

            //            Console.WriteLine($"Original Weight : {standardShipment.Weight} KG");

            //            standardShipment.UpdateWeight(5);

            //            Console.WriteLine($"Updated Weight : {standardShipment.Weight} KG");

            //            standardShipment.UpdateWeight(5, 0.5m);

            //            Console.WriteLine(
            //                $"Updated Weight After Packing : {standardShipment.Weight} KG"
            //            );

            //            //k. Mixed Shipment[] كدا جواها ال3 انواع  
            //            Shipment[] shipments =
            //{
            //    standardShipment,
            //    expressShipment,
            //    internationalShipment
            //};

            //            Console.WriteLine("\n==========================================");
            //            Console.WriteLine("Printing Using Shipment[]...");
            //            Console.WriteLine("==========================================");

            //            foreach (Shipment shipment in shipments)
            //            {
            //                shipment.PrintShipment();
            //                Console.WriteLine();
            //            }

            #endregion


            #region  OOP 04 -- Part 01 : Theoretical Questions

            //Q1  Abstraction

            //a)  What is Abstraction in Object-Oriented Programming?
            // Answer: Abstraction is the process of hiding the implementation details and
            // showinmg only the essential features of an object to the user

            //b)  Why is abstraction considered one of the four pillars of OOP?
            //Answer :because it  Reduces Complexity: It allows developers to interact with classes and methods through a clean, simplified interface without needing to understand the intricate internal logic.
            // Enhances Maintainability: Internal implementation details can be modified or refactored later without breaking the external code that relies on the class, as long as the public contract remains intact.
            // Improves Security: It restricts direct access to sensitive internal states, exposing only what is necessary for the object to function correctly.
            // Promotes Reusability and Extensibility: By focusing strictly on what an object does rather than how it does it, it establishes a flexible architecture that supports modular, reusable code across different parts of an application.


            //Q2  Abstract Classes vs. Interfaces

            //a)  What is the difference between an Abstract Class and an Interface?
            //Abstract Class :Provides a blueprint with abstract and non-abstract members.
            //Interface :Provides a contract with only method signatures (no implementation).

            //b)  When would you choose an Interface instead of an Abstract Class?
            //to enable multiple inheritance: When a class needs to inherit behavior or type definitions from multiple sources, since C# only supports single class inheritance.
            //For unrelated classes: When you want to define a common capability or role across completely unrelated classes(e.g., IComparable, IDisposable).
            //To define a strict contract: When you want to specify what actions a class must perform without sharing any base implementation, code, or internal state.
            //When designing APIs and decoupled systems: Interfaces are ideal for dependency injection and loose coupling because they decouple the definition of a service from its actual implementation.

            //c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            // Abstract Classes: No, a class cannot inherit from multiple abstract classes.C# restricts classes to a single base class to prevent complexity and issues like the diamond problem.
            //Interfaces: Yes, a class can implement multiple interfaces, separated by commas
            #endregion

            #region main oop04
            // ==========================================
            // Create Delivery Center
            // ==========================================

            DeliveryCenter center = new DeliveryCenter("Cairo Center");


            // ==========================================
            // a. Create StandardShipment
            // ==========================================

            StandardShipment standardShipment =
                new StandardShipment(
                    "SH001",
                    "Laptop",
                    3,
                    80,
                    new DeliveryAddress("Cairo", "Tahrir Street", 15)
                );


            // ==========================================
            // b. Create ExpressShipment
            // ==========================================

            ExpressShipment expressShipment =
                new ExpressShipment(
                    "SH002",
                    "Mobile Phone",
                    2,
                    60,
                    new DeliveryAddress("Cairo", "Nasr Street", 20),
                    30
                );


            // ==========================================
            // c. Create InternationalShipment
            // ==========================================

            InternationalShipment internationalShipment =
                new InternationalShipment(
                    "SH003",
                    "Television",
                    8,
                    120,
                    new DeliveryAddress("Cairo", "Main Street", 10),
                    "Germany",
                    100
                );


            // ==========================================
            // d. Add all shipments to DeliveryCenter
            // ==========================================

            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(internationalShipment);


            // ==========================================
            // e. Print all shipment details
            // ==========================================

            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");

            center.PrintAllShipments();


            // ==========================================
            // f. Print tracking status
            // ==========================================

            Console.WriteLine("\n==========================================");
            Console.WriteLine("Tracking Status");
            Console.WriteLine("==========================================");

            DeliveryReport.PrintShipment(standardShipment);
            Console.WriteLine();

            DeliveryReport.PrintShipment(expressShipment);
            Console.WriteLine();

            DeliveryReport.PrintShipment(internationalShipment);


            // ==========================================
            // g. Print insurance cost
            // ==========================================

            Console.WriteLine("\n==========================================");
            Console.WriteLine("Insurance");
            Console.WriteLine("==========================================");

            Console.WriteLine(
                $"Standard Shipment Insurance : " +
                $"{standardShipment.CalculateInsurance():0.00} EGP"
            );

            Console.WriteLine();

            Console.WriteLine(
                $"Express Shipment Insurance : " +
                $"{expressShipment.CalculateInsurance():0.00} EGP"
            );

            Console.WriteLine();

            Console.WriteLine(
                $"International Shipment Insurance : " +
                $"{internationalShipment.CalculateInsurance():0.00} EGP"
            );


            // ==========================================
            // h. ITrackable[] array
            // ==========================================

            ITrackable[] trackableShipments =
            {
        standardShipment,
        expressShipment,
        internationalShipment
    };

            Console.WriteLine("\n==========================================");
            Console.WriteLine("ITrackable[]");
            Console.WriteLine("==========================================");

            foreach (ITrackable shipment in trackableShipments)
            {
                Console.WriteLine(shipment.GetTrackingStatus());
            }


            // ==========================================
            // i. IInsurable[] array
            // ==========================================

            IInsurable[] insurableShipments =
            {
        standardShipment,
        expressShipment,
        internationalShipment
    };

            Console.WriteLine("\n==========================================");
            Console.WriteLine("IInsurable[]");
            Console.WriteLine("==========================================");

            foreach (IInsurable shipment in insurableShipments)
            {
                Console.WriteLine(
                    $"Insurance: {shipment.CalculateInsurance():0.00} EGP"
                );
            }


            // ==========================================
            // Interface Polymorphism
            // ==========================================

            Console.WriteLine("\n==========================================");
            Console.WriteLine(
                "Interface Polymorphism Demonstrated Successfully."
            );
            Console.WriteLine("==========================================");

            #endregion

        }
    }
}
