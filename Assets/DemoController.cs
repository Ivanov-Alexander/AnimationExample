using UnityEngine;
using System.Collections;

public class DemoController : MonoBehaviour {
	private Animator animator;
	void Start() {
		animator = GetComponent<Animator>();
	}

	void Update() {
		animator.SetFloat("VSpeed", Input.GetAxis("Vertical"));
	}
}
