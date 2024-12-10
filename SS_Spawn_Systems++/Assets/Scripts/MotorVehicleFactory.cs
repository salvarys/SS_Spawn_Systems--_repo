using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorVehicleFactory : IVehicleFactory
{
    public IVehicle Create(VehicleRequirements requirements)
    {
        if (requirements.NumberOfWheels <= 3) 
            return new MotorBikeFactory().Create(requirements);

        if (!requirements.HasCargo && requirements.NumberOfWheels == 4)
        {
            if (requirements.Passengers <= 4)
                return new Sedan();
            else
                return new MPV();
        }

        if (requirements.HasCargo && requirements.NumberOfWheels == 4)
            return new Van();

            switch (requirements.NumberOfWheels)
        {
            case 6:
            case 8:
                return new Truck();
            case 10:
                return new Tricycle();
            case 12:
                return new HeavyGoodsTruck();
            default:
                return new ArticulatedLorry();
        }
    }
}
