using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
  public float movementSpeed = 5.0f;
  public float clockwise = 1000.0f;
  public float counterClockwise = -5.0f;

  void Start()
  {

  }

  void Update()
  {
    if (Input.GetKey(KeyCode.W))
    {
      transform.position += transform.forward * Time.deltaTime * movementSpeed;
    }
    if (Input.GetKey(KeyCode.S))
    {
      //   rigidbody.position += Vector3.back * Time.deltaTime * movementSpeed;
      transform.position -= transform.forward * Time.deltaTime * movementSpeed;
    }
    if (Input.GetKey(KeyCode.A))
    {
      //   transform.position += transform.forward * Time.deltaTime * movementSpeed;
      transform.position -= transform.right * Time.deltaTime * movementSpeed;
    }
    if (Input.GetKey(KeyCode.D))
    {
      transform.position += transform.right * Time.deltaTime * movementSpeed;
    }

    if (Input.GetKey(KeyCode.E))
    {
      transform.Rotate(0, Time.deltaTime * clockwise, 0);
    }
    else if (Input.GetKey(KeyCode.Q))
    {
      transform.Rotate(0, Time.deltaTime * counterClockwise, 0);
    }
  }
}
