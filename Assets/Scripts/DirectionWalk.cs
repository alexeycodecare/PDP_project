using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionWalk : MonoBehaviour
{
  [SerializeField] private Transform _target;
  [SerializeField] private ConfigurableJoint _joint;
  [SerializeField] private Transform _pelvisTransform;

  void Start() {
    _target = GameObject.FindGameObjectWithTag("Player").transform;
  }

  void FixedUpdate() {
    Vector3 toTarget = _target.position - _pelvisTransform.position;
    Vector3 toTargetXZ = new Vector3(toTarget.x, 0f, toTarget.z);
    Quaternion rotation = Quaternion.LookRotation(toTargetXZ);

    _joint.targetRotation = Quaternion.Inverse(rotation);
  }
}
