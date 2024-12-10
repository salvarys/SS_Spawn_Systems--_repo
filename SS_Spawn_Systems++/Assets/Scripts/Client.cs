using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public bool hasEngine = true;
    public bool hasCargo = true;
    public int wheelCount = 4;
    public int passengerCount = 4;

    public string CreateVehicle()
    {
        var requirements = new VehicleRequirements();

        requirements.HasEngine = hasEngine;
        requirements.Passengers = passengerCount;
        requirements.HasCargo = hasCargo;
        requirements.NumberOfWheels = wheelCount;

        var vehicle = GetVehicle(requirements);

        Debug.Log(vehicle.GetType().Name);
        return (vehicle.GetType().Name);
    }
    private static IVehicle GetVehicle(VehicleRequirements requirements)
    {
        var factory = new VehicleFactory(requirements);
        return factory.Create();
    }
}
