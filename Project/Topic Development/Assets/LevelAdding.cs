using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAdding : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cylinder.transform.position = new Vector3(0,0,0);
            cylinder.transform.
        }
	}
}
