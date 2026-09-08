using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    #region 1. Create a DeliveryAddress struct 
    public class DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNumber;

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"{BuildingNumber} {Street} Street, {City}";
        }
    }
    #endregion

    #region Part 01 : Theoretical Questions - Question 1
    //public struct DeliveryAddress
    //{
    //    public string City;
    //    public string Street;
    //}
    //public class Customer
    //{
    //    public string Name;
    //}
    //a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
    // answer:DeliveryAddress is a struct  which is a value type  When you assign one DeliveryAddress variable
    // to another the entire contents are copied into a brand-new memory location
    // Modifying the copy afterwards only changes that copy — the original variable remain untouched.

    //b) What happens when a Customer variable is copied into another variable and one variable modifies the object
    // answer: Customer is a class, which is a reference type. Assigning one Customer variable to another just copies
    // the reference (the memory address), so both variables end up pointing to the same object. Modifying a field through
    // either variable changes the one shared object so the change is visible through both.
    #endregion

    #region Part 01 : Theoretical Questions - Question 2
    //a) a) Identify at least three problems with this design from an encapsulation perspective.
    // answer: 1- The fields are public, which means they can be accessed and modified directly from outside the class.
    // 2- There is no validation or control over how the fields are set or retrieved.
    // 3- The internal state of the object can be changed in unexpected ways, leading to potential inconsistencies.

    //b) b) How can private fields and public properties improve this design?
    // answer: we can control how the fields are accessed and modified. This allows
    // us to add validation logic, ensure data integrity, and provide a clear interface for interacting with the object's state.
    #endregion

}
