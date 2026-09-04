using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class StandardShipment : Shipment
    {
        //constractor shanning from the base class constructor
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
    

    public override decimal EstimatedCost
        {
            get
            {    
                return base.EstimatedCost;
            }
        }
    }
}
