using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	private float speed;

    [SerializeField]
    private float rotationSpeed;


    [SerializeField]
    private float jumpSpeed;

    private Rigidbody rigidbody;

    private bool onGround;

    private void OnCollisionStay(Collision collision) {
        if(collision.gameObject.tag == "Ground") {
            onGround = true;
        }
    }

    private void OnCollisionExit(Collision collision) {
        if (collision.gameObject.tag == "Ground") {
            onGround = false;
        }
    }

    private void Start() {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update() {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        } 

        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) && onGround) {
            rigidbody.velocity += new Vector3(0, jumpSpeed, 0);
        }
    }
}
