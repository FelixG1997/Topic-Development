using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCylinder : MonoBehaviour {

    private int lvlnr = 0;
    private GameObject cylinder;

    void Start() {
        
        cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        Vector3 dimensions = transform.localScale;
        dimensions.x += 5 * lvlnr;
        dimensions.y -= -0.5f;
        dimensions.z += 5 * lvlnr;

        cylinder.name = "Cylinder start";
        cylinder.transform.localScale = dimensions;
        cylinder.SetActive(false);
 

        /*
        Vector3 dimensions = transform.localScale;
        dimensions.x += 5 * lvlnr;
        dimensions.y /= 2;
        dimensions.z += 5 * lvlnr;
        */
        //cylinder = GameObject.FindGameObjectWithTag("StartCylinder");
        //cylinder = Instantiate(GameObject.FindGameObjectWithTag("StartCylinder"), new Vector3(0, 0 - lvlnr, 0), Quaternion.identity);


    }

    public void drawStartCylinder() {
        if (lvlnr == 0) {
            cylinder.SetActive(true);
            lvlnr++;
        }
        else if (lvlnr < 25) {
            lvlnr++;
        }
    }

    public void deleteStartCylinder() {
        if (lvlnr == 1) {
            cylinder.SetActive(false);
            lvlnr--;
        }
        else if (lvlnr > 0) {
            lvlnr--;
        }
    }

}