using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
  [SerializeField]
  private TMP_Text score;
  private int count;
  // Start is called before the first frame update
  void Start()
  {
    count = 0;
    score.text = count.ToString();
  }

  // Update is called once per frame
  void Update()
  {

  }
  public void IncScore()
  {
    count += 1;
    this.score.text = count.ToString();
  }
}
