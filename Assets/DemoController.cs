using UnityEngine;
using System.Collections;

public class DemoController : MonoBehaviour {
	private Animator animator;
	void Start() {
		animator = GetComponent<Animator>();
	}

	void Update() {
		animator.SetFloat("VSpeed", Input.GetAxis("Vertical"));

		if (Input.GetButtonDown("Jump")) {
			animator.SetBool("Jumping", true);
			Invoke("StopJumping", 0.1f);
		}

		if (Input.GetKey("q")) {
			transform.Rotate(Vector3.down * Time.deltaTime * 100.0f);
			if (Input.GetAxis("Vertical") == 0f) {
				animator.SetBool("TurningLeft", true);
			}
		} else {
			animator.SetBool("TurningLeft", false);
		}

		if (Input.GetKey("e")) {
			transform.Rotate(Vector3.up * Time.deltaTime * 100.0f);
			if (Input.GetAxis("Vertical") == 0f) {
				animator.SetBool("TurningRight", true);
			}
		} else {
			animator.SetBool("TurningRight", false);
		}

		if (Input.GetKey(KeyCode.LeftShift)) {
			animator.SetBool("Running", true);
		} else {
			animator.SetBool("Running", false);
		}


		if (Input.GetKeyDown("1")) {
			if (animator.GetInteger("CurrentAction") == 0) {
				animator.SetInteger("CurrentAction", 1);
			} else {
				animator.SetInteger("CurrentAction", 0);
			}
		}

		if (Input.GetKeyDown("2")) {
			if (animator.GetInteger("CurrentAction") == 0) {
				animator.SetInteger("CurrentAction", 2);
			} else {
				animator.SetInteger("CurrentAction", 0);
			}
		}

		if (Input.GetMouseButtonDown(0)) {
			animator.SetBool("Attack", true);
			Invoke("StopAttack", 0.1f);
		}

	}

	void StopJumping() {
		animator.SetBool("Jumping", false);
	}

	void StopAttack() {
		animator.SetBool("Attack", false);
	}
}
