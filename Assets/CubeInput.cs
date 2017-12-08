using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInput : MonoBehaviour
{

    public AudioClip []cubeNoise;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        HitKey1();
    }

    void HitKey1()
    {
        if (Input.GetKeyDown("1"))
        {
            SoundManager.instance.PlayOneShoot(true, cubeNoise);
        }

    }
}

