using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pallo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
	
	void OnTriggerEnter(Collider other)
    {
        Vector3 aloituspaikka = new Vector3(0, 0, 0);

        if (other.gameObject.tag == "maali")
        {
            Debug.Log("Ykköset saivat maalin");
		}
	}

}
