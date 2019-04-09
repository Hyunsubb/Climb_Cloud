using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    Rigidbody2D rigid2D;
    GameObject sound;
    Animator animator;
    float jumpForce = 400.0f;
    float walkForce = 24.0f;
    float maxWalkSpeed = 1.6f;

    void Start () {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.sound = GameObject.Find("SoundController");
        this.animator = GetComponent<Animator>();
	}

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        
        int key = 0;
        if (Input.GetKey(KeyCode.D))
            key = 1;
        if (Input.GetKey(KeyCode.A))
            key = -1;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);
 
        if (speedx < this.maxWalkSpeed)
            this.rigid2D.AddForce(transform.right * key * this.walkForce);

        if (key != 0)
            transform.localScale = new Vector3(key, 1, 1);

        this.animator.speed = speedx / 2.0f;

        if (transform.position.y < -10)
            SceneManager.LoadScene("GameScene");
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Cloud")
            sound.GetComponent<SoundController>().ttiyong.Play();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "flag")
            SceneManager.LoadScene("ClearScene");
    }
}
