using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class ProgressBar : FillBar
{
    private UnityEvent onProgressComplete;

    public Text endScreenTxt;
    public Button startProgressButton;
    public GameObject endScreenButton;

    public Text bronzeBadgeGoal;
    public Text silverBadgeGoal;
    public Text goldBadgeGoal;

    public GameObject bronzeBadgeSpriteMask;
    public GameObject silverBadgeSpriteMask;
    public GameObject goldBadgeSpriteMask;


    private bool finish;

    private float predictedDistance;
    private float speed;
    private float dynamicAddition;
    private float prozentualProgress;
    private float sumDynamicAddition;

    private float maxValueSlider;

    private bool bronzeAchieved;
    private bool silverAchieved;
    private bool goldAchieved;

    private float bronzeBadgeValue;
    private float silverBadgeValue;
    private float goldBadgeValue;

    private float bronzeBadgeAchievement;
    private float silverBadgeAchievement;
    private float goldBadgeAchievement;

    private float bronzeBadgeSpriteSteps;
    private float silverBadgeSpriteSteps;
    private float goldBadgeSpriteSteps;

    public new float CurrentValue
    {
        get
        {
            return base.CurrentValue;
        }
        set
        {
            if (value >= slider.maxValue)
                onProgressComplete.Invoke();

            base.CurrentValue = value;

        }
    }

    void OnProgressComplete()
    {
        Debug.Log("Progress Complete");
    }

    void Start()
    {

        startProgressButton.onClick.AddListener(StartProgress);

        bronzeBadgeValue = CooperResults.bronzeBadge;
        silverBadgeValue = CooperResults.silverBadge;
        goldBadgeValue = CooperResults.goldBadge;

        maxValueSlider = goldBadgeValue / 1000;
        slider.maxValue = maxValueSlider;

        bronzeBadgeGoal.text = bronzeBadgeValue.ToString() + "m";
        silverBadgeGoal.text = silverBadgeValue.ToString() + "m";
        goldBadgeGoal.text = goldBadgeValue.ToString() + "m";

        bronzeBadgeAchievement = (bronzeBadgeValue / goldBadgeValue) * maxValueSlider;
        silverBadgeAchievement = (silverBadgeValue / goldBadgeValue) * maxValueSlider;
        goldBadgeAchievement = maxValueSlider;



        endScreenButton.SetActive(true);
        endScreenButton.gameObject.transform.Translate(10000f, 10000f, 0f, 0);

     

        if (onProgressComplete == null)
            onProgressComplete = new UnityEvent();
        onProgressComplete.AddListener(OnProgressComplete);
    }

    void SecUpdate()
    {
        checkForBadge();
        startProgressButton.gameObject.transform.Translate(100f, 100f, 100f, 0);

        if (TimerScript.timeRemaining >= 0 && CurrentValue <= maxValueSlider)
        {
            // 15 km/h
            //CurrentValue += 0.004166f;
            // 14 km/h
            //speed = 0.003888f;
            // 12 km/h
            //CurrentValue += 0.003333f;
            // 10 km/h
            //CurrentValue += 0.002777f;
            // 5 km/h
            //CurrentValue += 0.001388f;

            // Gold Badge Speed, Male, 20, 2800m: 14 km/h, 0.003888f;
            //speed = 0.003888f;
            // Silver Badge Speed, Male, 20, 2400m: 12 km/h, 0.003333f;
            //speed = 0.003333f;
            // Bronze Badge Speed, Male, 20, 2200m: 11 km/h, 0.003055f;

            //speed = 0.003255f;

            speed = ReceiveSerialSkript.speed / 1000f;

            CurrentValue += (speed + dynamicAddition);

            sumDynamicAddition += dynamicAddition;


            if (!bronzeAchieved)
            {
                bronzeBadgeSpriteSteps = (73.0f / bronzeBadgeValue) * ((speed + dynamicAddition) * 1000f) * 0.038545f;
                bronzeBadgeSpriteMask.gameObject.transform.Translate(bronzeBadgeSpriteSteps, 0f, 0f);
            }
            if (bronzeAchieved == true && silverAchieved == false)
            {
                silverBadgeSpriteSteps = (73.0f / (silverBadgeValue - bronzeBadgeValue)) * ((speed + dynamicAddition) * 1000f) * 0.038545f;
                silverBadgeSpriteMask.gameObject.transform.Translate(silverBadgeSpriteSteps, 0f, 0f);
            }
            if (silverAchieved == true && goldAchieved == false)
            {
                goldBadgeSpriteSteps = (73.0f / (goldBadgeValue - silverBadgeValue)) * ((speed + dynamicAddition) * 1000f) * 0.038545f;
                goldBadgeSpriteMask.gameObject.transform.Translate(goldBadgeSpriteSteps, 0f, 0f);

            }


            if (CooperResults.condition == 3)
            {
                predictedDistance = CurrentValue + TimerScript.timeRemaining * speed;
                if (predictedDistance - sumDynamicAddition < bronzeBadgeAchievement)
                {
                    prozentualProgress = (predictedDistance - sumDynamicAddition) / bronzeBadgeAchievement;
                    prozentualProgress = (silverBadgeAchievement - bronzeBadgeAchievement) * prozentualProgress; 
                    dynamicAddition = ((bronzeBadgeAchievement + 0.001f + prozentualProgress) - predictedDistance) / TimerScript.timeRemaining;
                }
                else if (predictedDistance - sumDynamicAddition >= (bronzeBadgeAchievement + 0.005f) && predictedDistance < silverBadgeAchievement)
                {
                    prozentualProgress = (predictedDistance - sumDynamicAddition) / silverBadgeAchievement;
                    prozentualProgress = (goldBadgeAchievement - silverBadgeAchievement) * prozentualProgress;
                    dynamicAddition = ((silverBadgeAchievement + 0.001f + prozentualProgress) - predictedDistance) / TimerScript.timeRemaining;
                }
                else if (predictedDistance - sumDynamicAddition >= (silverBadgeAchievement + 0.005f) && predictedDistance < goldBadgeAchievement)
                {
                    prozentualProgress = predictedDistance - silverBadgeAchievement;
                    dynamicAddition = ((goldBadgeAchievement + 0.001f + prozentualProgress) - predictedDistance) / TimerScript.timeRemaining;
                }
                Debug.Log(dynamicAddition);


            }


        }

        if (TimerScript.timeRemaining < 0 && !finish)
        {
            checkForBadge();

            finish = true;

            Invoke("FinishExperiment", 5);

            WriteToJson();
        }
    }

    public void StartProgress()
    {
      
        InvokeRepeating("SecUpdate", 0, 1.0f);
    }

    private void checkForBadge()
    {
        if (CurrentValue >= bronzeBadgeAchievement && (!bronzeAchieved))
        {
          
            bronzeAchieved = true;
            Debug.Log("Bronze");
        }
        else if (CurrentValue >= silverBadgeAchievement && (!silverAchieved))
        {
           
            silverAchieved = true;
            Debug.Log("Silver");
        }
        else if (CurrentValue >= goldBadgeAchievement && (!goldAchieved))
        {
          
            goldAchieved = true;
            Debug.Log("Gold");
        }
    }

    private void FinishExperiment()
    {



        displayText.gameObject.SendMessageUpwards("moveDisplay", SendMessageOptions.DontRequireReceiver);
        endScreenButton.gameObject.transform.Translate(-10000f, -10000f, 0f, 0);

        endScreenTxt.text = "Congratulations!\nPress to continue!";
        

    }

    public void WriteToJson()
    {
        SaveData.userID = UserIDScript.userID;
        SaveData.condition = CooperResults.condition;
        SaveData.difficulty = CooperResults.difficulty;
        SaveData.age = CooperResults.age;
        SaveData.gender = CooperResults.gender;
        SaveData.genderStr = CooperResults.genderStr;
        SaveData.distanceTravelled = (CurrentValue * 1000).ToString("0000");
        SaveData.bronzeAchieved = bronzeAchieved;
        SaveData.silverAchieved = silverAchieved;
        SaveData.goldAchieved = goldAchieved;
        SaveData.bronzeBadge = CooperResults.bronzeBadge;
        SaveData.silverBadge = CooperResults.silverBadge;
        SaveData.goldBadge = CooperResults.goldBadge;
        SaveData.dynamicAddition = sumDynamicAddition;
    }
}
