﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vessanveto1 : MonoBehaviour
{

    public GameObject Poop3;
    //bool veto = false;
    AudioSource aani;
    public bool vessaHuuhdeltu = false;

    // Start is called before the first frame update
    void Start()
    {
        aani = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "kasi")
        {
            aani.Play();
            //veto = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "kasi")
        {
            if (vessaHuuhdeltu == false)
            {
                // veto = false;
                Poop3.transform.position = new Vector3(-2.8f, -0.7f, 2.7f);
                Debug.Log("poop giant gone");
                int points = GameObject.Find("pistelaskija").GetComponent<pisteet>().eritelikaPiste;
                Debug.Log("points " + points);
                GameObject.Find("pistelaskija").GetComponent<pisteet>().eritelikaPiste -= 1;
                vessaHuuhdeltu = true;
            }
        }
    }
}
