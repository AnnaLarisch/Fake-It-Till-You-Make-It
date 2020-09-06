using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class UserIDScript : MonoBehaviour
{
    public static int userID;
    public static int gender;
    public InputField idInput;
    public Dropdown genderDropdown;



    public void start()
    {
        InputField idInput = GameObject.Find("InputField - User ID").GetComponent<InputField>();
        Dropdown genderDropdown = GameObject.Find("Dropwdown - Gender").GetComponent<Dropdown>();

    }

    public void setUserID()
    {
        userID = Convert.ToInt32(idInput.text);
    }

    public void setGender()
    {
        gender = genderDropdown.value;
    }
}
