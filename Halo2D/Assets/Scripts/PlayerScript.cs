using UnityEngine;

/// <summary>
/// Contrôleur du joueur
/// </summary>
public class PlayerScript : MonoBehaviour
{
	/// <summary>
	/// 1 - La vitesse de déplacement
	/// </summary>
	public Vector2 speed = new Vector2(10, 10);
	
	// 2 - Stockage du mouvement
	private Vector2 movement;
	public float jumpSpeed = 200;
	
	void Update()
	{
		// 3 - Récupérer les informations du clavier/manette
		float inputX = Input.GetAxis("Horizontal");
		//float inputY = Input.GetAxis("Vertical");
		float inputY = Input.GetAxis("Jump");

		if (Input.GetButtonDown ("Jump")) {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0,jumpSpeed));
		}
		
		// 4 - Calcul du mouvement
		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);

		//if (Input.GetKey (KeyCode.Escape))
			//transform.Translate (new Vector2 (0, 1) * jumpSpeed * Time.deltaTime);
		
	}
	
	void FixedUpdate()
	{
		// 5 - Déplacement
		GetComponent<Rigidbody2D>().velocity = movement;
	}
}