using UnityEngine;
using System.Collections;

public class tanqueBehaviour : MonoBehaviour {

	public GameObject camera;
	public GameObject bala;
	private float rotacao = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rotacao = camera.transform.rotation.eulerAngles.y -90;
		transform.eulerAngles = new Vector3 (transform.rotation.x, rotacao, transform.rotation.z);//Quaternion (transform.rotation.x, i, transform.rotation.z, 0);

		if(Input.GetButtonDown("Fire1")){
			atira();
		}
	}

	void atira(){
		//somTiro.Play ();
		bala.SetActive (true);
		Instantiate (bala, bala.transform.position, Quaternion.identity);
		bala.SetActive (false);
	}
}
