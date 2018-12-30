
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    //float speed = 10.0f;
	protected Transform xFormCamera;
	protected Transform xFormParent;
	
	protected Vector3 localRotation;
	protected float cameraDistance = 10f;
	
	public float mouseSensitivity = 4f;
	public float scrollSensitivity = 2f;
	public float orbitDampening = 10f;
	public float scrollDampening = 6f;
	
	public bool cameraDisabled = false;
	
	private int plainNumber = 0;
	
	void Start(){
		this.xFormCamera = this.transform;
		this.xFormParent = this.transform.parent;
	}
	
	void LateUpdate(){
		
		if(Input.GetKeyDown(KeyCode.LeftShift)){
			cameraDisabled = ! cameraDisabled;
		}
		
		if(!cameraDisabled){
			// Rotation of Camera based on mouse coord.
			if(Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0){
				localRotation.x += Input.GetAxis("Mouse X") * mouseSensitivity; 
				localRotation.y += Input.GetAxis("Mouse Y") * mouseSensitivity;
				
				localRotation.y = Mathf.Clamp(localRotation.y, -plainNumber, 90f);
				
			}
			
			// Zooming
			if(Input.GetAxis("Mouse ScrollWheel") != 0f){
					float scrollAmount = Input.GetAxis("Mouse ScrollWheel") * scrollSensitivity;
					
					// faster zoom when further away from target
					scrollAmount *= this.cameraDistance * 0.3f;
					
					this.cameraDistance += scrollAmount * -1f;
					
					this.cameraDistance = Mathf.Clamp(this.cameraDistance, - plainNumber, 50f);
			}
		}
		
		// actual camera rotations
		Quaternion qt = Quaternion.Euler(localRotation.y, localRotation.x, 0);
		this.xFormParent.rotation = Quaternion.Lerp(this.xFormParent.rotation, qt, Time.deltaTime * orbitDampening);
		
		if(this.xFormCamera.localPosition.z != this.cameraDistance * -1f){
			this.xFormCamera.localPosition = new Vector3(0f, 0f, Mathf.Lerp(this.xFormCamera.localPosition.z, this.cameraDistance * -1f, Time.deltaTime * scrollDampening));
		}
    }
	
	public void incPlainNumber(){
		if(plainNumber<25){
			plainNumber++;
		}
		
	}
	
	public void decPlainNumber(){
		if(plainNumber>0){
			plainNumber--;
		}
		
	}

}