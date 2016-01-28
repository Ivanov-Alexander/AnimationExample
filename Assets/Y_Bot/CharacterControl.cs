using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {
	private Animator animator;
	void Start() {
		animator = GetComponent<Animator>();
	}

	void Update() {
		animator.SetFloat("VSpeed", Input.GetAxis("Vertical"));
		animator.SetFloat("HSpeed", Input.GetAxis("Horizontal"));
		if (Input.GetKey(KeyCode.LeftShift) && Input.GetAxis("Vertical") > 0) {
			animator.SetFloat("VSpeed", 2f);
		}
	}
}
