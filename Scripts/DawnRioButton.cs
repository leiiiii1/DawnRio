using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DawnRioButton : MonoBehaviour
{
    //things that will display on a button
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI HpText;
    public TextMeshProUGUI lvlText;


    public void SetDawnRioData(DawnRio character)
    {
        //displays the datas
        nameText.text = character.name;
        HpText.text = character.hp.ToString();
        lvlText.text = character.lvl.ToString();
    }
}
