using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kissa : MonoBehaviour
{
	public CharacterController controller;
	
	private float verticalSpeed = 0f;
	private float horizontalSpeed = 0f;
	
	public int speed = 3;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalSpeed = Input.GetAxis("Vertical");
		horizontalSpeed = Input.GetAxis("Horizontal");
		Vector3 direction = new Vector3(horizontalSpeed, -1, verticalSpeed);
		controller.Move(direction * Time.deltaTime * speed);
    }
}
