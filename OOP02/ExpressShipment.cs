using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;

        public decimal ExtraFee {  
            get{
            
                return extraFee;
            }
            set
            {
                if(value >= 0)
                    extraFee = value;
            }
        }
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            this.extraFee = extraFee;
        }
        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + ExtraFee;
            }
        }

    }
}
