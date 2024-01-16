using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float steerspeed = 250f;
    [SerializeField] private float movespeed = 20f;

    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float duration = 2f;


    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerspeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Boost"){
            Debug.Log("Boost");
            movespeed = boostSpeed;
        }
    }
    void OnCollisionEnter2D(Collision2D other) {
        movespeed = slowSpeed;
    }
}
