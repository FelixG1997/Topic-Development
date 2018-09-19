using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plain : MonoBehaviour
{

    private int lvlnr = 0;

    private GameObject[] cylinders = new GameObject[25];

    public void DrawPlain()
    {
        if (lvlnr < 25)
        {
            // create new cylinder
            GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

            // cylinder gets new Dimensions
            Vector3 dimensions = transform.localScale;
            dimensions.x += 3 * lvlnr + 5;
            dimensions.y /= 2;
            dimensions.z += 3 * lvlnr + 5;
            cylinder.transform.localScale = dimensions;

            // set cylinder position
            cylinder.transform.position = new Vector3(0, 0 - lvlnr, 0);

            cylinders[lvlnr] = cylinder;

            // inc lvl
            lvlnr++;


        }
    }

    public void DeletePlain()
    {
        if (lvlnr < 25)
        {
            lvlnr--;
            Destroy(cylinders[lvlnr]);
        }

    }
}