using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SaveData : MonoBehaviour
{
    [SerializeField] private UserData _UserData = new UserData();

    public static int userID;
    public static int condition;
    public static int difficulty;
    public static int age;
    public static int gender;
    public static string genderStr;
    public static string distanceTravelled;
    public static bool bronzeAchieved;
    public static bool silverAchieved;
    public static bool goldAchieved;
    public static int bronzeBadge;
    public static int silverBadge;
    public static int goldBadge;
    public static float dynamicAddition;

    public void SaveIntoJson()
    {

        _UserData.SetData(userID, condition, difficulty, age, gender, genderStr, distanceTravelled, bronzeAchieved, silverAchieved, goldAchieved, bronzeBadge, silverBadge, goldBadge, dynamicAddition);
        string user = JsonUtility.ToJson(_UserData);


        System.IO.File.WriteAllText(Application.persistentDataPath + "/UserData" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".json", user);
    }
}

[System.Serializable]
public class UserData
{
    public int userID;
    public int condition;
    public int difficulty;
    public int age;
    public int gender;
    public string genderStr;
    public string distanceTravelled;
    public bool bronzeAchieved;
    public bool silverAchieved;
    public bool goldAchieved;
    public int bronzeBadge;
    public int silverBadge;
    public int goldBadge;
    public float dynamicAddition;

    public void SetData(int userID, int condition, int difficulty, int age, int gender, string genderStr, string distanceTravelled, bool bronzeAchieved, bool silverAchieved, bool goldAchieved, int bronzeBadge, int silverBadge, int goldBadge, float dynamicAddition)
    {
        this.userID = userID;
        this.condition = condition;
        this.difficulty = difficulty;
        this.age = age;
        this.gender = gender;
        this.genderStr = genderStr;
        this.distanceTravelled = distanceTravelled;
        this.bronzeAchieved = bronzeAchieved;
        this.silverAchieved = silverAchieved;
        this.goldAchieved = goldAchieved;
        this.bronzeBadge = bronzeBadge;
        this.silverBadge = silverBadge;
        this.goldBadge = goldBadge;
        this.dynamicAddition = dynamicAddition;
    }

}

//  C:\Users\janla\AppData\LocalLow\DefaultCompany\Fake It Till You Make It
