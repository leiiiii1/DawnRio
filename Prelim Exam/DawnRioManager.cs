using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DawnRioManager : MonoBehaviour
{
    public DawnRio[] dawnRios;
    public string folderPath = "DawnRio";

    void Awake()
    {
        //store all the scriptable object into a single array called dawnRios
        dawnRios = Resources.LoadAll<DawnRio>(folderPath);
    }
}
