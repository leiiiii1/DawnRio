using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DawnRioSelection : MonoBehaviour
{
    public DawnRioManager dawnRioManager; //call the script that has all the dawnRios
    public Transform parentPos; // Get the position of the panel that has the horizontal layout group
    public GameObject dawnRioButtonprefab; //Get the button prefab you created
    public DawnRioInfoView dawnRioInfoView; //get the script that displays more info about the dawnrio

    void Start()
    {
        Debug.Log(dawnRioManager.dawnRios.Count()); //displays how many dawnRios are in the dawnRio manager

        //Create a button for each dawnrio in the dawnRioManager
        foreach (DawnRio d in dawnRioManager.dawnRios)
        {
            GameObject buttonPrefab = Instantiate(dawnRioButtonprefab, parentPos);
            DawnRioButton dawnRioButton = buttonPrefab.GetComponent<DawnRioButton>();

            dawnRioButton.SetDawnRioData(d);
            Button button = buttonPrefab.GetComponent<Button>(); 
            button.onClick.AddListener(() => dawnRioInfoView.DisplayDawnRio(d)); //Listens to the button, whenever clicked, it will open the information of the DawnRio
        }
    }
}
