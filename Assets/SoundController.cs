using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour {

    public AudioSource ttiyong;
    public AudioSource mainMusic;

    void Start () {
        mainMusic.loop = true;
        mainMusic.Play();
	}
	
	void Update () {
		
	}
}
