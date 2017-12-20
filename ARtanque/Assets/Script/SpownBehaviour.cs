using UnityEngine;
using System.Collections;

public class SpownBehaviour : MonoBehaviour {

	public GameObject robo;
	private int cont;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		cont = Random.Range (0, 1300);
		robo.gameObject.SetActive (true);
		if(cont == 0){
			Instantiate (robo, new Vector3(-45.2f, 59.45799f, 44.6f), Quaternion.identity);
		}else if(cont  == 1){
			Instantiate (robo, new Vector3(-45.2f, 59.45799f, -33.3f), Quaternion.identity);
		}else if(cont == 2){
			Instantiate (robo, new Vector3(-45.2f, 59.45799f, -16.6f), Quaternion.identity);
		}else if(cont == 3){
			Instantiate (robo, new Vector3(-24.5f, 59.45799f, 42.5f), Quaternion.identity);
		}else if(cont == 4){
			Instantiate (robo, new Vector3(-1f, 59.45799f, -42.5f), Quaternion.identity);
		}else if(cont == 5){
			Instantiate (robo, new Vector3(38f, 59.45799f, -4.3f), Quaternion.identity);
		}else if(cont == 6){
			Instantiate (robo, new Vector3(38f, 59.45799f, 40.3f), Quaternion.identity);
		}else if(cont == 7){
			Instantiate (robo, new Vector3(2.1f, 59.45799f, 40.3f), Quaternion.identity);
		}else if(cont == 8){
			Instantiate (robo, new Vector3(-34f, 59.45799f, 40.3f), Quaternion.identity);
		}
		robo.gameObject.SetActive (false);
	
	}
}
