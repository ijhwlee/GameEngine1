using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletController : MonoBehaviour
{
  [SerializeField]
  private float force = 100.0f;
  // Start is called before the first frame update
  void Start()
  {
    StartCoroutine(SelfDestruct());
  }

  // Update is called once per frame
  void Update()
  {
    //if (Input.GetMouseButtonDown(0))
    //{
    //  Shoot(new Vector3(0, 0, force));
    //}
  }
  public void Shoot(Vector3 dir) // dir은 항상 단위 벡터로 크기가 1임
  {
    GetComponent<Rigidbody>().AddForce(dir*force);
  }
  private void OnCollisionEnter(Collision collision)
  {
    if(collision.collider.tag == "ENEMY")
    {
      GameObject manager = GameObject.Find("ScoreManager");
      if(manager == null)
      {
        Debug.Log("ScoreManager is not found.");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
      }
      manager.GetComponent<ScoreManager>().IncScore();
      Destroy(gameObject, 0.2f);
    }
  }
  IEnumerator SelfDestruct()
  {
    yield return new WaitForSeconds(5f);
    Destroy(gameObject);
  }
}
