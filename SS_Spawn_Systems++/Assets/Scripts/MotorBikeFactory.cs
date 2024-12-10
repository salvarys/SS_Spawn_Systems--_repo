using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorBikeFactory : IVehicleFactory
{
    public IVehicle Create(VehicleRequirements requirements)
    {
        switch (requirements.NumberOfWheels)
        {
            case 2:
                return new MotorBike();
            case 3:
                return new TriBike();
            default:
                return new MotorBike();
        }
    }
}
