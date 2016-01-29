using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Bucket_script : MonoBehaviour 
{

	/*
	 * Detect when the tone has triggered the bucket
	 * 
	 * */


	// OCTET 4

	public Transform C4_t_animation;
	public Transform D4_y_animation;
	public Transform E4_u_animation;
	public Transform F4_i_animation;
	public Transform G4_o_animation;
	public Transform A5_p_animation;
	public Transform B5_a_animation;

	//OCTET 5

	public Transform C5_s_animation;
	public Transform D5_d_animation;
	public Transform E5_f_animation;
	public Transform F5_g_animation;
	public Transform G5_h_animation;
	public Transform A6_j_animation;
	public Transform B6_k_animation;

	//OCTET 6
	public Transform C6_l_animation;


	public static int score;




	void Start()
	{

		score = 0;
	}

	void OnTriggerEnter(Collider tone)
	{
		//Debug.Log ("Object detected is --->"+ tone.gameObject.tag);

		GameObject tone_detected = tone.gameObject;


		switch (tone_detected.tag) 
		{



		/* --------------------------------------------------------------------
		 * 
		 * OCTET 4
		 * --------------------------------------------------------------
		 * */


		case "C4_t":
			//Debug.Log ("a#5 detected");


			Object effect41 = Instantiate(C4_t_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect41 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself

			score++;

			break;



		case "D4_y":
			//Debug.Log ("a#5 detected");


			Object effect42 = Instantiate(D4_y_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect42 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself

			score++;

			break;


		case "E4_u":
			//Debug.Log ("a#5 detected");


			Object effect43 = Instantiate(E4_u_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect43 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself

			score++;

			break;



		case "F4_i":
			//Debug.Log ("a#5 detected");


			Object effect44 = Instantiate(F4_i_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect44 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself

			score++;

			break;




		case "G4_o":
			//Debug.Log ("a#5 detected");


			Object effect45 = Instantiate(G4_o_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect45 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself

			score++;

			break;

		case "A5_p":
			//Debug.Log ("a#5 detected");


			Object effect46 = Instantiate(A5_p_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect46 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself

			score++;

			break;



		case "B5_a":
			//Debug.Log ("a#5 detected");


			Object effect47 = Instantiate(B5_a_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect47 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself

			score++;

			break;



		



		/*
		 * -------------------------------------------------------
		 * OCTET 5
		 * ----------------------------------------------------
		 * */

		case "C5_s":
			//Debug.Log ("a#5 detected");


			Object effect51 = Instantiate (C5_s_animation, transform.position, transform.rotation);  // Instatiate the music animation

			Destroy ((effect51 as Transform).gameObject, 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself

			score++;

			break;


		case "D5_d":
			//Debug.Log ("a#5 detected");


			Object effect52 = Instantiate(D5_d_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect52 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself

			score++;


			break;



		case "E5_f":
			//Debug.Log ("a#5 detected");


			Object effect53 = Instantiate(E5_f_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect53 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself


			break;



		case "F5_g":
			//Debug.Log ("a#5 detected");


			Object effect54 = Instantiate(F5_g_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect54 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself

			score++;


			break;



		case "G5_h":
			//Debug.Log ("a#5 detected");


			Object effect55 = Instantiate(G5_h_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect55 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself

			score++;

			break;

		case "A6_j":
			//Debug.Log ("a#5 detected");


			Object effect56 = Instantiate(A6_j_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect56 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself


			score++;

			break;



		case "B6_k":
			//Debug.Log ("a#5 detected");


			Object effect57= Instantiate(B6_k_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect57 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself


			score++;

			break;


		


		
			/*------------------------------------------------
			 * OCTET 6
			 * -----------------------------------------------
			 * */

		case "C6_l":
			//Debug.Log ("a#5 detected");


			Object effect61 = Instantiate(C6_l_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect61 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself
			score++;


			break;

			/*

		case "g#5":
			//Debug.Log ("a#5 detected");


			Object effect11 = Instantiate(g_sharp_5_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect11 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself
			score++;

			break;



		case "g5":
			//Debug.Log ("a#5 detected");


			Object effect12 = Instantiate(g5_animation,transform.position,transform.rotation);  // Instatiate the music animation

			Destroy ((effect12 as Transform).gameObject , 1);  // destroy the animation after 1 second

			Destroy (tone_detected); // destroy the tone itself
			score++;
			break;




*/



		}

		/*Object effect = Instantiate(GetComponent<Animation>(),transform.position,transform.rotation);  // Instatiate the music animation


		Destroy ((effect as Transform).gameObject , 1);  // destroy the animation after 1 second

		Destroy (tone.gameObject); // destroy the tone itself


		// Detect which object is to be deleted first

		//  Destroy the object defferently 



		// Update the scroe

	*/

	}


}
