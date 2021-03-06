﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour //means inherets or extends to monobehavior
{
    // Start is called before the first frame update

        //public(inside world can use the variable)
        //or private only user knows variable exists reference
        [SerializeField]
        private float _speed = 5.5f;
    void Start()
    {
       //take the current position - new position (0x, 0y, 0z)
       transform.position = new Vector3(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction * _speed * Time.deltaTime);

        if(transform.position.y >= 0)
        {
            //making new vector object upon the transformatio when y is greater or equal to 0
            transform.position = new Vector3(transform.position.x, 0, 0);


        }else if(transform.position.y <= -3.8f)
        {
            //making new vector obj upon the transformation when x is less than or equal to -3.8f on the x axis
            transform.position = new Vector3(transform.position.x, -3.8f, 0);

        }

        //setting boundaries to wrap on the x axis!
        if(transform.position.x > 11.3f)
        {
            transform.position = new Vector3(-11.3f, transform.position.y, 0);
        }else if(transform.position.x < -11.3f)
        {
            transform.position = new Vector3(11.3f, transform.position.y, 0);
        }


        
        
    }
}
