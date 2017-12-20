using UnityEngine;
using System.Collections;

public class BalaBehaviour : MonoBehaviour {

	public GameObject bola;
	public GameObject mira;

	private Vector3 alvo;
	private bool atirou;

	// Use this for initialization
	void Start () {
		alvo = mira.transform.position;
		atirou = false;
	}

	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, alvo,1f);

		if(transform.position == alvo){
			Destroy (bola);
		}
	}

	void OnCollisionEnter(Collision other){
		Debug.Log ("toca!");
		Destroy (bola);
	}
}
