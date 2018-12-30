using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plain : MonoBehaviour{

    public int lvlnr = 0;
    public GameObject[] cylinders = new GameObject[25];


    public void drawPlain(){
        if (lvlnr < 25){
            
            // create new cylinder
            //cylinders[lvlnr] = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

            // cylinder gets new Dimensions
            Vector3 dimensions = transform.localScale;
            dimensions.x += 5 * (lvlnr + 1);
            dimensions.y /= 2;
            dimensions.z += 5 * (lvlnr + 1);

            cylinders[lvlnr] = Instantiate(GameObject.FindGameObjectWithTag("MotherCylinder"), new Vector3(0, 0 - (lvlnr + 1), 0), Quaternion.identity);
            cylinders[lvlnr].name = "Cylinder " + lvlnr;
            cylinders[lvlnr].transform.localScale = dimensions;
      
            lvlnr++;
        }

        //https://www.youtube.com/watch?v=-0eqAUkKQpI
    }



    public void deletePlain(){
        if (lvlnr>0){
            lvlnr--;
            Destroy(cylinders[lvlnr]);

        }
    }
}