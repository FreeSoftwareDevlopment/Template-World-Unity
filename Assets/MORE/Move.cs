using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     public float movementSpeed = 10;
	
	 
     void Update(){
          if(Input.GetKey(KeyCode.W))
        {
        transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
		}
		  if(Input.GetKey(KeyCode.S))
        {
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
		}
	
		if (Input.GetKey(KeyCode.A)){
			transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D)){
			transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
		}
     }
}
