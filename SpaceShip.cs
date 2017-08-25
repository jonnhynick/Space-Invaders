using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour {
    public float speed = 30;    //represents the speed of set object

    public GameObject theBullet;
    void FixedUpdate()  //needed when rigid body components are used in order to move the object
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(horizontalMove, 0) * speed;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(theBullet, transform.position, Quaternion.identity);

            SoundManager.Instance.PlayOneShot(SoundManager.Instance.bulletFire);
        }
	}
}
