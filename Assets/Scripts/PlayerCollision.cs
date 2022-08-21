using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  public int maxHealth = 100;
  public int currentHealth;

  public HealthBar healthBar;

  private void Start() {
    currentHealth = maxHealth;
    healthBar.SetHealth(maxHealth);
  }

  private void OnCollisionEnter(Collision collisionInfo) {
    if (collisionInfo.collider.tag == "Damage") {
      TakeDamage(10);
    }
  }

  private void TakeDamage(int damage) {
    currentHealth -= damage;
    healthBar.SetHealth(currentHealth);

    if (currentHealth <= 0) {
      FindObjectOfType<GameManager>().EndGame();
      FindObjectOfType<PlayerController>().PlayerDead();
    }
  }
}
