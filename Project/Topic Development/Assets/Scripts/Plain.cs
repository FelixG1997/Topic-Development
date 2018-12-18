using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plain : MonoBehaviour
{

    public int lvlnr;
    public GameObject[] cylinders = new GameObject[25];
	//private GameObject[] buttons = new GameObject[25];

	void start(){
			lvlnr = 0;
	}
	
    public void drawPlain()
    {
        if (lvlnr < 25)
        {
            // create new cylinder
            cylinders[lvlnr] = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
			cylinders[lvlnr].name = "Cylinder " + lvlnr;

            // cylinder gets new Dimensions
            Vector3 dimensions = transform.localScale;
            dimensions.x += 5 * lvlnr;
            dimensions.y /= 2;
            dimensions.z += 5 * lvlnr;
            cylinders[lvlnr].transform.localScale = dimensions;

            // set cylinder position
            cylinders[lvlnr].transform.position = new Vector3(0, 0 - lvlnr, 0);
                     
            // inc lvl
            lvlnr++;
            
			
			
        }
    }

    public void deletePlain()
    {
        if (lvlnr>=0)
        {
            lvlnr--;
            Destroy(cylinders[lvlnr]);
        }

    }
	
	private void createBtn(){
		//cylinders[lvlnr]
	}
	
	public int getLvlNr(){
		return this.lvlnr;
	}
	
	/*
	<20:19:20> "Kongraa": Input.GetKeyDown(KeyCode.E)
<20:19:25> "Kongraa": Mouse0
<20:20:13> "Kongraa": void Update () {
        if (Input.GetKeyDown(KeyCode.E) && Vector3.Distance(transportableObject.transform.position,this.transform.position) < 20) {
            if (!hold){
                transportableObject.transform.parent = this.transform.GetChild(0).transform;
                hold = true;
            }
            else{
                transportableObject.transform.parent = null;
                hold = false;
            }
            
        }
    }
	*/
}