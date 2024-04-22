using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  [SerializeField] private Transform _target;
  [SerializeField] private Transform _cameraTransform;
  [SerializeField] public float perspective = 10f;

  void Start() {
    _target = GameObject.FindGameObjectWithTag("Player").transform;
  }

  void FixedUpdate() {
    if (_target) {
      Vector3 toTargetXZ = new Vector3(_target.position.x, _cameraTransform.position.y, _target.position.z - perspective);
      _cameraTransform.position = toTargetXZ;
    }
  }
}
