using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kissa : MonoBehaviour
{
	public CharacterController controller;
	public Animator animator;
	
	private float verticalSpeed = 0f;
	private float horizontalSpeed = 0f;
	
	private float mouseMovement = 0f;
	
	public int speed = 3;
	public int mouseSpeed = 3;
	
	[SerializeField]
	private float forceMagnitude;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //eteen ja sivulle liikkuminen
		verticalSpeed = Input.GetAxis("Vertical");
		horizontalSpeed = Input.GetAxis("Horizontal");
		Vector3 direction = new Vector3(horizontalSpeed, -1, verticalSpeed);
		
		//hiirellä kääntyminen
		mouseMovement += Input.GetAxis("Mouse X") * mouseSpeed;
		transform.localRotation = Quaternion.Euler(0, mouseMovement, 0);
		direction = transform.rotation * direction;
		
		//tämä lopulta liikuttaa
		controller.Move(direction * Time.deltaTime * speed);
		
		//animaatiot
		if(verticalSpeed != 0){
			animator.SetBool("Walk", true);
		}
		else{
			animator.SetBool("Walk", false);
		}
		
    }

	/*
	void OnControllerColliderHit(ControllerColliderHit hit){
		//Debug.Log("Tyonna");
		Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
		forceDirection.y = 0;
		forceDirection.Normalize();
		
		GetComponent<Rigidbody>().AddForceAtPosition(forceDirection * forceMagnitude, transform.position, ForceMode.Impulse);
	}
	
	
	void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "maali")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Maali");
            
            //GUI.text = "Some Text Here";
        }
    }
	*/
	
	//Kissan törmäys tyhjään maaliin
	void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Maali2")
        {
            Debug.Log("Kissa maalissa2");
		}
	}
	
}










