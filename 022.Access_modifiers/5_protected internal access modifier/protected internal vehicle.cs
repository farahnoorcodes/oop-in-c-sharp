using System;
namespace _5_protected_internal_access_modifier
{
    public  class protected_internal_vehicle//// Base class: public, so a derived class in another project could inherit from it.
    {
        protected internal string vehicle_name;//This modifier grants access if either condition is true: the caller is in the same assembly, or the caller is a derived class (even in a different assembly).
        protected internal string vehicle_model;
        protected internal string engine_type;
        protected internal void ShowVehicle()
        {
            Console.WriteLine("Vehicle: " + vehicle_name);
            Console.WriteLine("Vehicle Model: " + vehicle_model);
            Console.WriteLine("Engine Type: " + engine_type);
        }   
    }
    // Derived class: uses the members directly through the protected rule.
   
        public class car : protected_internal_vehicle
        {
            public void set_car_details(string name, string type,string model )
            {
                vehicle_name = name;
                engine_type = type;
                vehicle_model = model;
            }
        }
    
}
