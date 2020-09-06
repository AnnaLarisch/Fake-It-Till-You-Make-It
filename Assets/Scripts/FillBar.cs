using UnityEngine;
using UnityEngine.UI;

public class FillBar : MonoBehaviour
{

    // Unity UI References
    public Slider slider;
    public Text displayText;

    // Create a property to handle the slider's value
    private float currentValue = 0f;

    public float CurrentValue
    {
        get
        {
            return currentValue;
        }
        set
        {
            currentValue = value;
            slider.value = currentValue;
            if (value <= slider.maxValue)
            {
                if (slider.value * 1000 < 10)
                {
                    displayText.text = (slider.value * 1000).ToString("0") + " m";
                }
                if(slider.value * 1000 < 100 && slider.value * 1000 >= 10)
                {
                    displayText.text = (slider.value * 1000).ToString("00") + " m";
                }
                if(slider.value * 1000 < 1000 && slider.value * 1000 >= 100)
                {
                    displayText.text = (slider.value * 1000).ToString("000") + " m";
                }
                if(slider.value * 1000 >= 1000)
                {
                    displayText.text = (slider.value * 1000).ToString("0000") + " m";
                }
            }
            if (value > slider.maxValue)
            {
                displayText.text = "Congratulations!";
            }


        }
    }

    // Use this for initialization
    void Start()
    {
        CurrentValue = 0f;
    }

    public void moveDisplay()
    {
        displayText.transform.Translate(10000, 10000, 0, 0);
    }
}