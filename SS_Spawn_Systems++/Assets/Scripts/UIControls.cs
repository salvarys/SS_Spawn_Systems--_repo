using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIControls : MonoBehaviour
{
    [SerializeField] private Client _client;
    public TextMeshProUGUI currentVehicleText;
    public TextMeshProUGUI numberOfWheelsText;
    public TextMeshProUGUI numberOfPassengersText;
    public Slider passengersSlider;
    public Slider wheelsSlider;
    public Toggle cargoToggle;
    public Toggle engineToggle;
    private void Start()
    {
        SetValue();
    }
    public void SetValue ()
    {
        _client.passengerCount = (int) passengersSlider.value;
        _client.wheelCount = (int)wheelsSlider.value;
        _client.hasCargo = cargoToggle.isOn;
        _client.hasEngine = engineToggle.isOn;

        numberOfWheelsText.text = ((int)wheelsSlider.value).ToString();
        numberOfPassengersText.text = ((int)passengersSlider.value).ToString();

        currentVehicleText.text = _client.CreateVehicle();
    }
}
