namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Create a DeliveryAddress struct 
            DeliveryAddress address1 = new DeliveryAddress("New York", "Main Street", 123);

            DeliveryAddress address2 = address1;
            address2.City = "Giza";
            address2.Street = "Pyramids Street";
            address2.BuildingNumber = 100;

            Console.WriteLine("original address:");
            Console.WriteLine(address1.GetFullAddress());

            Console.WriteLine("\nCopied Address after modification:");
            Console.WriteLine(address2.GetFullAddress());
            #endregion

            #region 6. In Main, build a Console Application
            // a. Create a DeliveryCenter
            DeliveryCenter center = new DeliveryCenter();

            // b & c. Read data for three shipments
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nEnter Shipment {i + 1} Data");

                // Tracking Code
                Console.Write("Tracking Code: ");
                string trackingCode = Console.ReadLine();

                // Description
                Console.Write("Description: ");
                string description = Console.ReadLine();

                // Weight
                double weight;
                do
                {
                    Console.Write("Weight: ");
                }
                while (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0);

                // Delivery Fee
                double deliveryFee;
                do
                {
                    Console.Write("Delivery Fee: ");
                }
                while (!double.TryParse(Console.ReadLine(), out deliveryFee) || deliveryFee <= 0);

                // Destination
                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                int buildingNumber;
                do
                {
                    Console.Write("Building Number: ");
                }
                while (!int.TryParse(Console.ReadLine(), out buildingNumber) ||
                       buildingNumber <= 0);

                DeliveryAddress address =
                    new DeliveryAddress(city, street, buildingNumber);

                // Create Shipment
                Shipment shipment = new Shipment(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    address
                );

                // Add Shipment
                if (center.AddShipment(shipment))
                {
                    Console.WriteLine("\nShipment added successfully.");
                }
                else
                {
                    Console.WriteLine("\nDelivery Center is full.");
                }
            }

            // d. Print the three shipments using integer indexer
            Console.WriteLine("\n--- All Shipments ---");

            for (int i = 0; i < 3; i++)
            {
                Shipment shipment = center[i];

                Console.WriteLine($"--- Shipment {i + 1} ---");
                shipment.PrintShipment();
                Console.WriteLine();
            }

            // e. Ask user for tracking code
            Console.Write("\nEnter a tracking code to search: ");
            string searchCode = Console.ReadLine();

            // f. Search using string indexer
            Shipment foundShipment = center[searchCode];

            // g. Print result
            if (!string.IsNullOrWhiteSpace(foundShipment.TrackingCode))
            {
                Console.WriteLine(
                    $"Shipment Found: {foundShipment.TrackingCode} - " +
                    $"{foundShipment.Description}"
                );

                foundShipment.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            // h. Demonstrate DeliveryAddress struct copy behavior
            Console.WriteLine("\n--- Struct Copy Test ---");

            DeliveryAddress originalAddress =
                new DeliveryAddress("Cairo", "Tahrir Street", 15);

            DeliveryAddress copiedAddress = originalAddress;

            // Modify the copy
            copiedAddress.City = "Giza";
            copiedAddress.Street = "Makram Ebeid Street";
            copiedAddress.BuildingNumber = 20;

            Console.WriteLine(
                $"Original Address: {originalAddress.GetFullAddress()}"
            );

            Console.WriteLine(
                $"Copied Address: {copiedAddress.GetFullAddress()}"
            );
            #endregion
        }
    }
}
