using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject buttle;
    public float Speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject b= GameObject.Instantiate(buttle, transform.position, transform.rotation);
            Rigidbody rgb = b.GetComponent<Rigidbody>();
            rgb.velocity = transform.forward * Speed;
        }

                
    }   

}
