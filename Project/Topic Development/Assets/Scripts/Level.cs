using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour {
    public GameObject cylinder;
    public int lvlnr;
    public int cylinderIndex;

    // Start is called before the first frame update
    void Start() {
        cylinder.SetActive(false);
        lvlnr = -1;
    }

    public void addLevel() {
        if (lvlnr < 9) {
            lvlnr++;
            if (lvlnr == cylinderIndex) {
                cylinder.SetActive(true);
            }
        }
    }

}
