using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start gebeurt lekker aan het begin! 
    void Start()
    {
        
    }

    // Update is om het te updaten natuurlijk!
    void Update()
    {
        transform.position = player.transform.position + offset;
        
    
    }
}
