using UnityEngine;
using System.Collections;

public class RoboBehaviour : MonoBehaviour {

	public GameObject tanque;
	public TextMesh kills;

	private bool estaNoChao;
	private bool caiuNoChao;
	private bool estaMorto;
	private float cont;

	// Use this for initialization
	void Start () {
		estaNoChao = false;
		caiuNoChao = false;
		estaMorto = false;
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (transform.eulerAngles.z.ToString());

		if(transform.position.y <= -2.29f){
			estaNoChao = true;
			transform.LookAt (new Vector3(tanque.transform.position.x, -2.28911f, tanque.transform.position.z));
			transform.Rotate (new Vector3(0, 90, 0));
			transform.position = Vector3.MoveTowards (transform.position, new Vector3 (tanque.transform.position.x, 3.787979f, tanque.transform.position.z), 0.05f);	
		}

		if((transform.eulerAngles.z >= 80 && transform.eulerAngles.z <= 90) || (transform.eulerAngles.z >= 270 && transform.eulerAngles.z <= 280)){
			caiuNoChao = true;
			cont += Time.deltaTime;
			if(cont >= 4){
				Destroy (transform.gameObject);
			}
		}

		if(caiuNoChao == true && estaMorto == false){
			kills.text = (int.Parse(kills.text) + 1).ToString();
			estaMorto = true;
		}
	}


		
}
