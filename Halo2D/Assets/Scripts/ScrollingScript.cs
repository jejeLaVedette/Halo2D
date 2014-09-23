using UnityEngine;

/// <summary>
/// Parallax scrolling
/// </summary>
public class ScrollingScript : MonoBehaviour
{
	//on passe le perso en paramètre
	public Transform player;

	void Start()
	{
		
	}

	void Update()
	{
		transform.position = new Vector3 (player.position.x + 5, player.position.y / 2, -10);
		                          
	}
}