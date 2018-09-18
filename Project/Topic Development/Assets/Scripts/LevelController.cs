using UnityEngine;

public class LevelController : MonoBehaviour {

    // counter for levels
    int cntLvl = 0;
    // cylinder array, maximum set to 25
    GameObject[] cylinders = new GameObject[25];

    public void BtnAddPressed() {

        // avoid ArrayOutOfBounceException
        if (cntLvl < 25) {
            // create new cylinder
            GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

            // cylinder gets new Dimensions
            Vector3 dimensions = transform.localScale;
            dimensions.x += 3 * cntLvl+5;
            dimensions.y /= 2;
            dimensions.z += 3 * cntLvl+5;
            cylinder.transform.localScale = dimensions;

            // set cylinder position
            cylinder.transform.position = new Vector3(0, 0 - cntLvl, 0);

            // safe cylinder in Array
            cylinders[cntLvl] = cylinder;

            // inc levelcounter
            cntLvl++;
        }
    }

    public void BtnDeletePressed() {
    
        if (cntLvl > 0)
        {
            // decrease level counter
            cntLvl--;
            // Destroy cylinder with deepest level
            Destroy(cylinders[cntLvl]);
            
        }

   
    }

    }
