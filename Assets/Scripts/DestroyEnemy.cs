using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
  [SerializeField] private GameObject _wound;
  [SerializeField] private int _scoreToAdd = 1;
  [SerializeField] private int _hits = 10;

  private Transform _target;
  private Score _scoreBoard;

  public HealthBar _healthBarEnemy;

  void Start() {
    _target = GameObject.FindGameObjectWithTag("Player").transform;
    _scoreBoard = FindObjectOfType<Score>();
    _healthBarEnemy.SetHealth(_hits);
  }

  private void OnParticleCollision(GameObject other) {
    if (gameObject.name == "Pelvis" && gameObject.transform.parent.gameObject) {
      GameObject woundGameObject = Instantiate(_wound, transform.position, Quaternion.identity);

      Vector3 toTarget = _target.position - transform.position;
      Quaternion rotation = Quaternion.LookRotation(toTarget);
      woundGameObject.transform.rotation = rotation;

      _scoreBoard.ScoreHit(_scoreToAdd);

      Destroy(woundGameObject, 1f);

      _hits--;
      _healthBarEnemy.SetHealth(_hits);

      if (_hits <= 0) {
        Destroy(gameObject.transform.parent.gameObject);
        FindObjectOfType<EnemiesCount>().decrement();
      }
    }
  }

}
