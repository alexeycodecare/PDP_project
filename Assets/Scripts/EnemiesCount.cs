using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesCount : MonoBehaviour
{
  private GameObject[] Enemies;
  private int enemiesCounter = 0;
  
  void Start() {
    Enemies = GameObject.FindGameObjectsWithTag("Enemy");
    enemiesCounter = Enemies.Length;
  }

  public void decrement() {
    enemiesCounter--;

    if(enemiesCounter <= 0) {
      FindObjectOfType<GameManager>().CompleatLevel();
    }
  }

  public void increment() {
    enemiesCounter++;
  }
}
