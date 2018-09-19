using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    private int lvlnr = 0;

    private GameObject[] cylinders = new GameObject[25];

    public GameObject buttonPrefab;
    public GameObject panelToAttachButtonsTo;

    public void AddLevelButton(){


    }

    void OnClick()
    {
        Debug.Log("clicked!");
    }

    public void DeleteLevelButton() {

    }

}