using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Dit is prive, niet kijken!
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start gebeurt voor de eerste frame update!
    void Start()
    {
        
    }

    // Dit update dingen in de game
    void Update()
    {
         // waarom is dit zo simpel, dit heb ik al gedaan voor project zonder uitleg. 
         horizontalInput = Input.GetAxis("Horizontal");
          forwardInput = Input.GetAxis("Vertical");
       
    //okay dit zorgt er dus voor dat je naar voren gaat!
    transform.Translate (Vector3.forward * Time.deltaTime * speed * forwardInput);
    //en dit zorgt er dus voor dat je kan roteren enzo!
    transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
   
    }
}
