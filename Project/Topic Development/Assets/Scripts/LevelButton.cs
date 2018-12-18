using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour {

	GameObject[] cylinders;
	Plain plain;
	
	void Start(){
		plain = GetComponent<Plain>();
	}
	
	void Update(){
		cylinders = plain.cylinders;
		for(int i=0; i<25; i++){
			if(cylinders[i]!=null){
				//Debug.Log(cylinders[i].transform.position + ", " + Input.mousePosition + ": " + Vector3.Distance(cylinders[i].transform.position, Input.mousePosition));
				
				//if (Input.GetKeyDown(KeyCode.Mouse0) && Vector3.Distance(cylinders[i].transform.position, Input.mousePosition)<=300) {
				//	Debug.Log("Clicked, distance = " + Vector3.Distance(cylinders[i].transform.position, Input.mousePosition) + ", i: " + i );
				//}
				
				// TODO: work with Sphere Collider / Mesh || Create 1 cylinder with script (deactivated) -> activate with add -> clone with other adds || https://www.youtube.com/watch?v=-0eqAUkKQpI
				
			}
        }
		
	}
	
}