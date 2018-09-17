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
          
            Vector3 dimensions = transform.localScale;

            dimensions.x += 2;
            dimensions.z += 2;
            
            cylinder.transform.localScale = dimensions;

        }
	}
}
