using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal static class DeliveryReport
    {
        // كدا مش محتاج اعرف نوع ال shipment لان كلهم من نفس النوع 
        public static void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public static void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine(
                $"Insurance Cost: {shipment.CalculateInsurance()} EGP"
            );
        }
    }
}
