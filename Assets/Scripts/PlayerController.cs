using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static JS_Manager.JSManager;

public class PlayerController : MonoBehaviour
{
  private Animator _animator;
  private Rigidbody rb;
  public float speed = 0.1f;

  void Start() {
    _animator = gameObject.GetComponentInChildren<Animator>();
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
    if (translationX == 0 && translationY == 0) {
      _animator.SetBool("isWalk", false);
    } else {
      _animator.SetBool("isWalk", true);
    }
  }

  void PlayerRotate() {
    RaycastHit hit;

    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    if(Physics.Raycast(ray, out hit)) {
      transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
    }
  }

  public void PlayerDead() {
    Destroy(gameObject);
    JS_PlayerDead();
  }
}
