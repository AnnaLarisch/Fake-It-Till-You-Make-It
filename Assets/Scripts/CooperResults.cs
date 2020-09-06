using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CooperResults : MonoBehaviour
{
    public static int age;
    public static int gender;
    public static int condition;
    public static int difficulty = 2;
    public static int bronzeBadge;
    public static int silverBadge;
    public static int goldBadge;
    public static string genderStr;

    public InputField ageInput;


    public void Start()
    {
        InputField ageInput = GameObject.Find("InputField - Age").GetComponent<InputField>();
    }

    public void setAge()
    {
        age = Convert.ToInt32(ageInput.text);
    }

    public void setGender()
    {
        gender = UserIDScript.gender;
        if (gender == 0)
        {
            genderStr = "male";
        }
        if (gender == 1)
        {
            genderStr = "female";
        }
    }

    public void setBaselineCondition()
    {
        condition = 1;
    }

    public void setCustomizationCondition()
    {
        condition = 2;
    }

    public void setDynamicAdjustmentCondition()
    {
        condition = 3;
    }

    public void setCustomizationConditionDifficultyEasy()
    {
        difficulty = 0;
    }

    public void setCustomizationConditionDifficultyMedium()
    {
        difficulty = 1;
    }

    public void setCustomizationConditionDifficultyHard()
    {
        difficulty = 2;
    }

    public void setBadges()
    {
        if (age < 13)
        {
            bronzeBadge = 1000;
            silverBadge = 2000;
            goldBadge = 3000;
        }
        if (age >= 13 && age <= 14)
        {
            if (gender == 0)
            {
                if (condition == 1 || condition == 3)
                {
                    bronzeBadge = 2200;
                    silverBadge = 2400;
                    goldBadge = 2700;
                }
                if (condition == 2)
                {
                    if (difficulty == 0)
                    {
                        bronzeBadge = 1600;
                        silverBadge = 2100;
                        goldBadge = 2200;
                    }
                    if (difficulty == 1)
                    {
                        bronzeBadge = 2100;
                        silverBadge = 2200;
                        goldBadge = 2400;
                    }
                    if (difficulty == 2)
                    {
                        bronzeBadge = 2200;
                        silverBadge = 2400;
                        goldBadge = 2700;
                    }
                }
            }
            if (gender == 1)
            {
                if (condition == 1 || condition == 3)
                {
                    bronzeBadge = 1600;
                    silverBadge = 1900;
                    goldBadge = 2000;
                }
                if (condition == 2)
                {
                    if (difficulty == 0)
                    {
                        bronzeBadge = 1200;
                        silverBadge = 1500;
                        goldBadge = 1600;
                    }
                    if (difficulty == 1)
                    {
                        bronzeBadge = 1500;
                        silverBadge = 1600;
                        goldBadge = 1900;
                    }
                    if (difficulty == 2)
                    {
                        bronzeBadge = 1600;
                        silverBadge = 1900;
                        goldBadge = 2000;
                    }
                }
            }
        }

        if (age >= 15 && age <= 16)
        {
            if (gender == 0)
            {
                if (condition == 1 || condition == 3)
                {
                    bronzeBadge = 2300;
                    silverBadge = 2500;
                    goldBadge = 2800;
                }
                if (condition == 2)
                {
                    if (difficulty == 0)
                    {
                        bronzeBadge = 1700;
                        silverBadge = 2200;
                        goldBadge = 2300;
                    }
                    if (difficulty == 1)
                    {
                        bronzeBadge = 2200;
                        silverBadge = 2300;
                        goldBadge = 2500;
                    }
                    if (difficulty == 2)
                    {
                        bronzeBadge = 2300;
                        silverBadge = 2500;
                        goldBadge = 2800;
                    }
                }
            }
            if (gender == 1)
            {
                if (condition == 1 || condition == 3)
                {
                    bronzeBadge = 1700;
                    silverBadge = 2000;
                    goldBadge = 2100;
                }
                if (condition == 2)
                {
                    if (difficulty == 0)
                    {
                        bronzeBadge = 1300;
                        silverBadge = 1600;
                        goldBadge = 1700;
                    }
                    if (difficulty == 1)
                    {
                        bronzeBadge = 1600;
                        silverBadge = 1700;
                        goldBadge = 2000;
                    }
                    if (difficulty == 2)
                    {
                        bronzeBadge = 1700;
                        silverBadge = 2000;
                        goldBadge = 2100;
                    }
                }
            }
        }

        if (age >= 17 && age <= 19)
        {
            if (gender == 0)
            {
                if (condition == 1 || condition == 3)
                {
                    bronzeBadge = 2500;
                    silverBadge = 2700;
                    goldBadge = 3000;
                }
                if (condition == 2)
                {
                    if (difficulty == 0)
                    {
                        bronzeBadge = 1800;
                        silverBadge = 2300;
                        goldBadge = 2500;
                    }
                    if (difficulty == 1)
                    {
                        bronzeBadge = 2300;
                        silverBadge = 2500;
                        goldBadge = 2700;
                    }
                    if (difficulty == 2)
                    {
                        bronzeBadge = 2500;
                        silverBadge = 2700;
                        goldBadge = 3000;
                    }
                }
            }
            if (gender == 1)
            {
                if (condition == 1 || condition == 3)
                {
                    bronzeBadge = 1800;
                    silverBadge = 2100;
                    goldBadge = 2300;
                }
                if (condition == 2)
                {
                    if (difficulty == 0)
                    {
                        bronzeBadge = 1400;
                        silverBadge = 1700;
                        goldBadge = 1800;
                    }
                    if (difficulty == 1)
                    {
                        bronzeBadge = 1700;
                        silverBadge = 1800;
                        goldBadge = 2100;
                    }
                    if (difficulty == 2)
                    {
                        bronzeBadge = 1800;
                        silverBadge = 2100;
                        goldBadge = 2300;
                    }
                }
            }
        }

        if (age >= 20 && age <= 29)
        {
            if (gender == 0)
            {
                if (condition == 1 || condition == 3)
                {
                    bronzeBadge = 2200;
                    silverBadge = 2400;
                    goldBadge = 2800;
                }
                if (condition == 2)
                {
                    if (difficulty == 0)
                    {
                        bronzeBadge = 1300;
                        silverBadge = 1600;
                        goldBadge = 2400;
                    }
                    if (difficulty == 1)
                    {
                        bronzeBadge = 1600;
                        silverBadge = 2200;
                        goldBadge = 2400;
                    }
                    if (difficulty == 2)
                    {
                        bronzeBadge = 2200;
                        silverBadge = 2400;
                        goldBadge = 2800;
                    }
                }
            }
            if (gender == 1)
            {
                if (condition == 1 || condition == 3)
                {
                    bronzeBadge = 1800;
                    silverBadge = 2200;
                    goldBadge = 2700;
                }
                if (condition == 2)
                {
                    if (difficulty == 0)
                    {
                        bronzeBadge = 1200;
                        silverBadge = 1500;
                        goldBadge = 1800;
                    }
                    if (difficulty == 1)
                    {
                        bronzeBadge = 1500;
                        silverBadge = 1800;
                        goldBadge = 2200;
                    }
                    if (difficulty == 2)
                    {
                        bronzeBadge = 1800;
                        silverBadge = 2200;
                        goldBadge = 2700;
                    }
                }
            }
        }

        if (age >= 30 && age <= 39)
        {
            if (gender == 0)
            {
                if (condition == 1 || condition == 3)
                {
                    bronzeBadge = 1900;
                    silverBadge = 2300;
                    goldBadge = 2700;
                }
                if (condition == 2)
                {
                    if (difficulty == 0)
                    {
                        bronzeBadge = 1200;
                        silverBadge = 1500;
                        goldBadge = 1900;
                    }
                    if (difficulty == 1)
                    {
                        bronzeBadge = 1500;
                        silverBadge = 1900;
                        goldBadge = 2300;
                    }
                    if (difficulty == 2)
                    {
                        bronzeBadge = 1900;
                        silverBadge = 2300;
                        goldBadge = 2700;
                    }
                }
            }
            if (gender == 1)
            {
                if (condition == 1 || condition == 3)
                {
                    bronzeBadge = 1700;
                    silverBadge = 2000;
                    goldBadge = 2500;
                }
                if (condition == 2)
                {
                    if (difficulty == 0)
                    {
                        bronzeBadge = 1100;
                        silverBadge = 1400;
                        goldBadge = 1700;
                    }
                    if (difficulty == 1)
                    {
                        bronzeBadge = 1400;
                        silverBadge = 1700;
                        goldBadge = 2000;
                    }
                    if (difficulty == 2)
                    {
                        bronzeBadge = 1700;
                        silverBadge = 2000;
                        goldBadge = 2500;
                    }
                }
            }
        }

        if (age >= 40 && age <= 49)
        {
            if (gender == 0)
            {
                if (condition == 1 || condition == 3)
                {
                    bronzeBadge = 1700;
                    silverBadge = 2100;
                    goldBadge = 2500;
                }
                if (condition == 2)
                {
                    if (difficulty == 0)
                    {
                        bronzeBadge = 1100;
                        silverBadge = 1400;
                        goldBadge = 1700;
                    }
                    if (difficulty == 1)
                    {
                        bronzeBadge = 1400;
                        silverBadge = 1700;
                        goldBadge = 2100;
                    }
                    if (difficulty == 2)
                    {
                        bronzeBadge = 1700;
                        silverBadge = 2100;
                        goldBadge = 2500;
                    }
                }
            }
            if (gender == 1)
            {
                if (condition == 1 || condition == 3)
                {
                    bronzeBadge = 1500;
                    silverBadge = 1900;
                    goldBadge = 2300;
                }
                if (condition == 2)
                {
                    if (difficulty == 0)
                    {
                        bronzeBadge = 1000;
                        silverBadge = 1200;
                        goldBadge = 1500;
                    }
                    if (difficulty == 1)
                    {
                        bronzeBadge = 1200;
                        silverBadge = 1500;
                        goldBadge = 1900;
                    }
                    if (difficulty == 2)
                    {
                        bronzeBadge = 1500;
                        silverBadge = 1900;
                        goldBadge = 2300;
                    }
                }
            }
        }

        if (age >= 50)
        {
            if (gender == 0)
            {
                if (condition == 1 || condition == 3)
                {
                    bronzeBadge = 1600;
                    silverBadge = 2000;
                    goldBadge = 2400;
                }
                if (condition == 2)
                {
                    if (difficulty == 0)
                    {
                        bronzeBadge = 1000;
                        silverBadge = 1300;
                        goldBadge = 1600;
                    }
                    if (difficulty == 1)
                    {
                        bronzeBadge = 1300;
                        silverBadge = 1600;
                        goldBadge = 2000;
                    }
                    if (difficulty == 2)
                    {
                        bronzeBadge = 1600;
                        silverBadge = 2000;
                        goldBadge = 2400;
                    }
                }
            }
            if (gender == 1)
            {
                if (condition == 1 || condition == 3)
                {
                    bronzeBadge = 1400;
                    silverBadge = 1700;
                    goldBadge = 2200;
                }
                if (condition == 2)
                {
                    if (difficulty == 0)
                    {
                        bronzeBadge = 900;
                        silverBadge = 1100;
                        goldBadge = 1400;
                    }
                    if (difficulty == 1)
                    {
                        bronzeBadge = 1100;
                        silverBadge = 1400;
                        goldBadge = 1700;
                    }
                    if (difficulty == 2)
                    {
                        bronzeBadge = 1400;
                        silverBadge = 1700;
                        goldBadge = 2200;
                    }
                }
            }
        }
    }
}