using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Options : MonoBehaviour
{
    public TMP_Dropdown rockChoiceDropdown;

    public void SaveOptions()
    {
        int selectedChoice = rockChoiceDropdown.value;
        PlayerPrefs.SetInt("RockChoice", selectedChoice);
    }
}