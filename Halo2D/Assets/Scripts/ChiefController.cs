using UnityEngine;
using System.Collections;

public class ChiefController : MonoBehaviour {

	public Animator anim;
	public float speed=8f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		//on recup les touches clavier dédiées aux déplacement latéral
		float x = Input.GetAxis("Horizontal");
		anim.SetFloat ("speed", Mathf.Abs (x));

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
