using UnityEngine;
using System.Collections;

public class ChiefController : MonoBehaviour {

	public Animator anim;
	public float speed=2f;
	public int jumpSpeed = 350;

	//variable pour : tant que tu ne touches pas le seul : je ne saute pas 
	public Transform checkSol;
	bool toucheLeSol = false;
	float rayonSol = 0.3f;
	//defini : qu'est-ce que le sol
	public LayerMask Sol;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate(){
		toucheLeSol = Physics2D.OverlapCircle (checkSol.position, rayonSol, Sol);
		anim.SetBool ("Sol", toucheLeSol); 
	}
	
	// Update is called once per frame
	void Update () {
		//on recup les touches clavier dédiées aux déplacement latéral
		float x = Input.GetAxis("Horizontal");
		anim.SetFloat ("speed", Mathf.Abs (x));

		//gestion du saut
		if (toucheLeSol && Input.GetButtonDown ("Jump")) {
			rigidbody2D.AddForce(new Vector2(0,jumpSpeed));
		}

		//si je me déplace vers la droite
		if (x > 0) {
			//changement de la position
			transform.Translate (x * speed * Time.deltaTime,0,0);
			transform.eulerAngles = new Vector2(0,0);
		}
		//si je vais vaire la gauche
		if (x < 0) {
			transform.Translate (-x * speed * Time.deltaTime,0,0);
			//on effectue une translation de 180° au sprite
			transform.eulerAngles = new Vector2(0,180);
		}
	}
}
