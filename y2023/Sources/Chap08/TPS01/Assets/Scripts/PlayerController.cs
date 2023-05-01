using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField]
  private float speed = 10.0f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if(Input.GetKey(KeyCode.LeftArrow))
    {
      transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
      transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
  }
}
