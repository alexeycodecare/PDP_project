using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
  private Transform _target;

  private void Start() {
    _target = GameObject.FindGameObjectWithTag("MainCamera").transform;
  }

  void LateUpdate() {
    transform.LookAt(transform.position + _target.forward);
  }
}
