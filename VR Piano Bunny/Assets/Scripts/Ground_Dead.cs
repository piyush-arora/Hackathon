using UnityEngine;
using System.Collections;

public class Ground_Dead : MonoBehaviour 
{
	private int hashDead = Animator.StringToHash("Base Layer.Dead");

	private Animator animator;
	private CharacterController controller;

	public Transform GameOver;

	public GameObject Rabbit;

	public static bool dead = false;

	public void DoSomething()
	{


	}


	void Start()
	{
		animator = Rabbit.GetComponent<Animator>();
		controller = Rabbit.GetComponent<CharacterController>();

	}

	void OnCollisionEnter(Collision Tone)
	{

		//Debug.Log ("DETECTED" +  Tone.gameObject.tag);

		if (animator && dead == false) 
		{
			animator.Play (hashDead);
		
			Object effect = Instantiate (GameOver, transform.position, transform.rotation);
			Destroy ((effect as Transform).gameObject, 2);

			Destroy (Rabbit, 3);


		}

		dead = true;
		
	}




}
