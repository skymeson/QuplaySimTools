using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class MainSlider : MonoBehaviour
{

    public Slider sliderRoll;
    public Slider sliderPitch;
    public Slider sliderYaw;
    public Slider sliderHeave;
    public Slider sliderSway;
    public Slider sliderSurge;
    public Slider sliderExtra1;
    public Slider sliderExtra2;
    public Slider sliderExtra3;

    // Start is called before the first frame update
    void Start()
    {
        //Adds a listener to the main slider and invokes a method when the value changes.
        sliderRoll.onValueChanged.AddListener(delegate { ValueChangeCheck(sliderRoll); });
        sliderPitch.onValueChanged.AddListener(delegate { ValueChangeCheck(sliderPitch); });
        sliderYaw.onValueChanged.AddListener(delegate { ValueChangeCheck(sliderYaw); });


    }

    // Invoked when the value of the slider changes.
    public void ValueChangeCheck(Slider slider)
    {
        Debug.Log("OnValueChanged: " + slider.gameObject.name + " " +slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        //QuPlaySimtools.QuSimtools_SendTelemetry(
        //    Random.RandomRange(-180, 180),
        //    Random.RandomRange(-180, 180),
        //    Random.RandomRange(-180, 180),
        //    Random.RandomRange(-180, 180),
        //    Random.RandomRange(-180, 180),
        //    Random.RandomRange(-180, 180),
        //    Random.RandomRange(-180, 180),
        //    Random.RandomRange(-180, 180),
        //    Random.RandomRange(-180, 180));

        Debug.Log(string.Format("Sending Telemetry data : {0} : {1} : {2}", sliderRoll.value, sliderPitch.value, sliderYaw.value));
        QuPlaySimtools.QuSimtools_SendTelemetry(
                    sliderRoll.value,
                    sliderPitch.value,
                    sliderYaw.value,
                    0f,
                    0f,
                    0f,
                    Random.RandomRange(-180, 180),
                    Random.RandomRange(-180, 180),
                    Random.RandomRange(-180, 180));
    }
}
