using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
  int score = 0;
  Text scoreText;

  [SerializeField] private FloatSO scoreSO;

  void Start() {
    scoreText = GetComponent<Text>();
    scoreText.text = scoreSO.Value.ToString();
  }

  public void ScoreHit(int scorePerHit) {
    scoreSO.Value += scorePerHit;
    scoreText.text = scoreSO.Value.ToString();
  }
}
