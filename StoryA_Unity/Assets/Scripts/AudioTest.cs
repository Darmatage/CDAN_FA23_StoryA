using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioTest : MonoBehaviour
{

    public AudioSource SFXClip1;
    public AudioSource SFXClip2;
    public AudioSource SFXClip3;

    void Update()
    {
        if (Input.GetKeyDown("5"))
        {
            SFXClip1.Play();
        }
    }
}