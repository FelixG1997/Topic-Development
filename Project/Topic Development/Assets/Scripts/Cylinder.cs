using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour{

    /*
    // Start is called before the first frame update
    void Start(){
        plain = GetComponent<Plain>();
        index = plain.lvlnr;
        cylinder = plain.cylinders[index];

        Debug.Log(index);
    }
    */

    // Update is called once per frame
    void Update(){
        
    }

    void OnMouseDown() {
        Destroy(gameObject);
    }

}
