﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrioMove : MonoBehaviour
{
    //these three are ALWAYS. Attrached to light... be careful. Based on intensity(more implementations later). 

    public GameObject FlashLight;
    public Transform[] targets;
    public float speed;
    bool directionSwitch;
    int curr;
    private void Start()
    {
        speed = 3f;
        curr = 0; directionSwitch = false;
    }

    private void Update()
    {
        if (FlashLight.activeInHierarchy)
        {
            FindCat();
        }
        //otherwise, find the nearest light source

    }
        void FindCat(){

            if (transform.position != targets[curr].position)
            {
                //Rotates to Target's Position
                transform.LookAt(new Vector3(targets[curr].position.x, transform.position.y, targets[curr].position.z));
                Vector3 pos = Vector3.MoveTowards(transform.position, targets[curr].position, speed * Time.deltaTime);
                GetComponent<Rigidbody>().MovePosition(pos);
            }
            else
            {
            ++curr;

            if (curr == targets.Length)
               {
                    curr = 0;
               }
            }

        
    }



}
