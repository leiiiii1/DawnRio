using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "DawnRio" , menuName = "ScriptableObjects/DawnRio")]
public class DawnRio : ScriptableObject
{
    //things that will be shown  on the button
    [Header("Basic Information")]
    public string name;
    public int hp;
    public int lvl;

    //more things that will be shown after the button is clicked
    [Header("Indepth Information")]
    public int bondLvl;
    public string bGStory;
    public StatusEnum status;
    public GenderEnum gender;
    public Sprite sprite;

    //stats of the dawnrio
    [Header("Stats")]
    public int atk;
    public int def;

    //the keyword that will play the animation
    [Header("For Animation")]
    public string triggerName;
      

    // a method that will call on the animation and trigger to start it
    public void StartAnimation(GameObject gameObject)
    {
        Animator animator = gameObject.GetComponentInChildren<Animator>();

        if (animator != null)
        {
            animator.SetTrigger(triggerName);
        }
    }

}
