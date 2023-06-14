using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movimento : MonoBehaviour
{

public float velocity = 40f;
public float rotation = 500f;
public Rigidbody rb;

void Start()
{
Cursor.lockState = CursorLockMode.Locked;
rb = GetComponent<Rigidbody>();
}

void Update()
{

float x = Input.GetAxis("Horizontal");
float y = Input.GetAxis("Vertical");
float mouseX = Input.GetAxis("Mouse X");

Vector3 dir = new Vector3(x, 0, y) * velocity;

transform.Translate(dir * Time.deltaTime);
transform.Rotate(new Vector3(0,mouseX * rotation * Time.deltaTime,0));


if(Input.GetButtonDown("Jump")) {
rb.AddForce(new Vector3(0, 2, 0), ForceMode.Impulse);

 }

}

}