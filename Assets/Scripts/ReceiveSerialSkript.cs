using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ReceiveSerialSkript : MonoBehaviour
{
    private const float beltLength = 3.8f;
    SerialPort sp = new SerialPort("COM3", 9600);
    public static int lightValue;
    public float counter;
    public static float speed;

    public void Start()
    {
        sp.Open();
        sp.ReadTimeout = 500;
        InvokeRepeating("CustomUpdate", 0, 0.01f);
        InvokeRepeating("printSpeed", 0, 1f);

    }

    public void CustomUpdate()
    {
        try
        {
            int.TryParse(sp.ReadLine(), out lightValue);
            //print(lightValue);
            if (lightValue >= 600)
            {
                counter += 1;
            }
            else
            {
                if (counter <= 50)
                {
                    speed = 1.0f;
                    counter = 0;
                }
                else
                {
                    speed = (beltLength / counter) * 100;
                    counter = 0;
                }
                
            }
        }
        catch (System.Exception)
        {
        }
    }

    public void printSpeed()
    {
        Debug.Log(speed + "m/s");
    }
}