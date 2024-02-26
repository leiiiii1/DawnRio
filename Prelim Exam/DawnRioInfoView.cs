using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DawnRioInfoView : MonoBehaviour
{
    //get the dawnrios and animation
    public DawnRio dawnRio;
    public GameObject animation;

    //Displays the info of Dawnrio
    public TextMeshProUGUI nameTMP;
    public TextMeshProUGUI bGStoryTMP;
    public TextMeshProUGUI statusTMP;
    public TextMeshProUGUI genderTMP;
    public TextMeshProUGUI hpTMP;
    public TextMeshProUGUI atkTMP;
    public TextMeshProUGUI defTMP;
    public TextMeshProUGUI lvlTMP;
    public TextMeshProUGUI bondLvlTMP;

    //when clicked it will open displaydawnrio
    public void OnEnable()
    {
        DisplayDawnRio(dawnRio);
    }


    //show everything written in the method
    public void DisplayDawnRio(DawnRio dawnRio)
    {
        //call the animation for the image
        dawnRio.StartAnimation(animation);

        //Texts
        nameTMP.text = dawnRio.name;
        bGStoryTMP.text = "BackStory: " + dawnRio.bGStory;
        statusTMP.text = "Status: " + dawnRio.status.ToString();
        genderTMP.text = "Gender: " + dawnRio.gender.ToString();
        hpTMP.text = "HP: " + dawnRio.hp.ToString();
        atkTMP.text = "Atk: " + dawnRio.atk.ToString();
        defTMP.text = "Def: " + dawnRio.def.ToString();
        lvlTMP.text = "Lvl: " + dawnRio.lvl.ToString();
        bondLvlTMP.text = "Bond Lvl: " + dawnRio.bondLvl.ToString();
    }

 
    public void OnDisable()
    {
        //Clear the info presented
        ClearInfo();
    }

    public void ClearInfo()
    {
        //have the values in the DisplayDawnRio turn to null
        dawnRio = null;
        animation = null;
        nameTMP.text = null;
        bGStoryTMP.text = null;
        statusTMP.text = null;
        genderTMP.text = null;
        hpTMP.text = null;
        lvlTMP.text = null;
        bondLvlTMP.text = null;
    }
}
