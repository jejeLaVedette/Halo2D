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
	
	void Update()
	{
		// 3 - Récupérer les informations du clavier/manette
		float inputX = Input.GetAxis("Horizontal");
		//float inputY = Input.GetAxis("Vertical");
		float inputY = Input.GetAxis("Jump");
		
		// 4 - Calcul du mouvement
		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);
		//movement = new Vector2(
			//speed.x * inputX);
		
	}
	
	void FixedUpdate()
	{
		// 5 - Déplacement
		rigidbody2D.velocity = movement;
	}
}