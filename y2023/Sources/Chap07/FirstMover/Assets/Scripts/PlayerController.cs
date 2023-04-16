using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField]
  private float speed = 10.0f;
  Rigidbody rigidBody;
  // Start is called before the first frame update
  void Start()
  {
    rigidBody = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    if(Input.GetKey(KeyCode.LeftArrow) == true)
    {
      transform.Translate(Vector3.left * speed * Time.deltaTime);
      //rigidBody.AddForce(-speed, 0f, 0f);
    }
  }
}
