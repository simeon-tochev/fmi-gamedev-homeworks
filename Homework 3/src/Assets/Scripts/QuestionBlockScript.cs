using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBlockScript : MonoBehaviour
{
    public GameObject mushroom;
    public Sprite emptyBlock;
    public Vector3 spawnOffset;

    private bool hit;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.name == "Mario" && !hit) {
            hit = true;
            GameObject.Instantiate(mushroom, transform.position + spawnOffset, transform.rotation);
            GetComponent<SpriteRenderer>().sprite = emptyBlock;
        }
    }
}
