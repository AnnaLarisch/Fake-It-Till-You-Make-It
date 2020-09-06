using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text txt;
    public Button startTimerButton;

    private bool timerStartBool;
    public static float timeRemaining = 720;

    public void Start()
    {
        startTimerButton = startTimerButton.GetComponent<Button>();
        startTimerButton.onClick.AddListener(StartTimer);
        txt = gameObject.GetComponent<Text>();
        txt.text = "00:00/12:00";
    }

    void Update()
    {
        if (timerStartBool)
        {
            startTimerButton.gameObject.transform.Translate(1000f, 1000f, 1000f, 0);
            timeRemaining -= Time.deltaTime;
            float minutes = 11 - Mathf.FloorToInt(timeRemaining / 60);
            float seconds = 59 - Mathf.FloorToInt(timeRemaining % 60);


            if (minutes < 10 && seconds < 10)
            {
                txt.text = "0" + minutes + ":0" + seconds + "/12:00";
            }
            if (minutes < 10 && seconds >= 10)
            {
                txt.text = "0" + minutes + ":" + seconds + "/12:00";
            }
            if (minutes >= 10 && seconds < 10)
            {
                txt.text = minutes + ":0" + seconds + "/12:00";
            }
            if (minutes >= 10 && seconds >= 10)
            {
                txt.text = minutes + ":" + seconds + "/12:00";
            }
            if (timeRemaining <= 0)
            {
                txt.text = "Time is up!";
            }
        }
    }

    public void StartTimer()
    {
        timerStartBool = true;
    }
}
