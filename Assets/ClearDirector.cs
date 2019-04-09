using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour {



	void Start () {
		
	}
	
	void Update () {
        if (Input.GetMouseButtonDown(0) ||
            Input.GetKeyDown(KeyCode.Space) || Input.GetKey(KeyCode.Return))
                SceneManager.LoadScene("GameScene");
	}
}
