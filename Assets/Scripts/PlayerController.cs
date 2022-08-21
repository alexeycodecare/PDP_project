using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private Rigidbody rb;
  public float speed = 0.05f;

  void Start() {
  }

  void FixedUpdate() {
    PlayerMove();
    PlayerRotate();

    if (transform.position.y < -1f) {
      FindObjectOfType<GameManager>().EndGame();
    }
  }

  void PlayerMove() {
    float translationX = Input.GetAxis("Vertical") * speed;
    float translationY = Input.GetAxis("Horizontal") * speed;
    transform.Translate(translationY, 0, translationX, Space.World);
  }

  void PlayerRotate() {
    RaycastHit hit;

    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    if(Physics.Raycast(ray, out hit)) {
      transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
    }
  }

  public void PlayerDead() {
    Debug.Log("Player dead");
    Destroy(gameObject);
  }
}
