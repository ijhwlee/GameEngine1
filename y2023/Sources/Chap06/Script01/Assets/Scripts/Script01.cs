using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script01 : MonoBehaviour
{
  [SerializeField]
  private int privateVariable = 5;
  public int publicVariable = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    Debug.Log("Hello, 드론IoT시뮬레이션학부");
    }
}
