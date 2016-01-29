using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Master_Game : MonoBehaviour  {




	public float Gravity;

	public Slider slider;


	/*
		Start positions of the tones
	*/

	//OCTET 4

	public Vector3 Start_Position_C4_t ;
	public Vector3 Start_Position_D4_y ;
	public Vector3 Start_Position_E4_u ;
	public Vector3 Start_Position_F4_i ;
	public Vector3 Start_Position_G4_o ;
	public Vector3 Start_Position_A5_p ;
	public Vector3 Start_Position_B5_a ;



	// OCTET 5
	public Vector3 Start_Position_C5_s ;
	public Vector3 Start_Position_D5_d ;
	public Vector3 Start_Position_E5_f ;
	public Vector3 Start_Position_F5_g ;
	public Vector3 Start_Position_G5_h ;
	public Vector3 Start_Position_A6_j ;
	public Vector3 Start_Position_B6_k ;




	//OCTET 6
	public Vector3 Start_Position_C6_l ;





	/*
	 * TONES 
	 * */

	//OCTET 5
	public Transform C5_s;
	public Transform D5_d;
	public Transform E5_f;
	public Transform F5_g;
	public Transform G5_h;
	public Transform A6_j;
	public Transform B6_k;


	//OCTET 4

	public Transform C4_t;
	public Transform D4_y;
	public Transform E4_u;
	public Transform F4_i;
	public Transform G4_o;
	public Transform A5_p;
	public Transform B5_a;



	// OCTET 6

	public Transform C6_l;




	/*
	 * Starting height of tones
	 * 
	 * */

	//public static float C5_s_height;


	//public Transform a_sharp_5, a5,b5, c5 , c_sharp_5,d5,d_sharp_5,e5,f5,f_sharp_5,g5,g_sharp_5;



	public Text Score_Text;
	public Toggle vr_mode;



	void twinkle_twinkle()
	{

		/* 
		 * twinkle twinkle little star
		 */

		play_note (C4_t,4.1f);   //t
		play_note (C4_t,4.3f);
	
		play_note (G4_o,4.6f);  //o
		play_note (G4_o,4.8f);

		play_note (A5_p,5.1f);   //p
		play_note (A5_p,5.3f);

		play_note (G4_o,5.6f);   //o



		/* 
		 * How i wonder what you are
		 */

		play_note (F4_i,5.9f);   //i
		play_note (F4_i,6.1f);

		play_note (E4_u,6.4f);    //u
		play_note (E4_u,6.6f);

		play_note (D4_y,6.9f);    //y
		play_note (D4_y,7.1f);

		play_note (C4_t,7.4f);     //t


		/*
		 * what anove so 
		 */

		play_note (G4_o,7.7f);  //o
		play_note (G4_o,7.9f);

		play_note (F4_i,8.2f);   //i
		play_note (F4_i,8.4f);

		play_note (E4_u,8.7f);    //u
		play_note (E4_u,8.9f);

		play_note (D4_y,9.2f);    //y


		/*
		 * like a diamond in the sky
		 * 
		 */

		play_note (G4_o,9.5f);  //o
		play_note (G4_o,9.7f);

		play_note (F4_i,10.0f);   //i
		play_note (F4_i,10.2f);

		play_note (E4_u,10.5f);    //u
		play_note (E4_u,10.7f);

		play_note (D4_y,11.0f);    //y



		/* 
		 * twinkle twinkle little star
		 */

		play_note (C4_t,11.3f);   //t
		play_note (C4_t,11.5f);

		play_note (G4_o,11.8f);  //o
		play_note (G4_o,12.0f);

		play_note (A5_p,12.3f);   //p
		play_note (A5_p,12.5f);

		play_note (G4_o,12.8f);   //o



		/* 
		 * How i wonder what you are
		 */

		play_note (F4_i,13.1f);   //i
		play_note (F4_i,13.3f);
	
		play_note (E4_u,13.6f);    //u
		play_note (E4_u,13.8f);

		play_note (D4_y,14.1f);    //y
		play_note (D4_y,14.3f);

		play_note (C4_t,14.6f);     //t



	}


	void Start () 
	{

		Physics.gravity = new Vector3(0, -1*Gravity, 0);

		twinkle_twinkle ();

	/*	play_note (C4_t,2.1f);
		play_note (D4_y,2.2f);
		play_note (E4_u,2.3f);
		play_note (F4_i,2.4f);
		play_note (G4_o,2.5f);
		play_note (A5_p,2.6f);
		play_note (B5_a,2.7f);


		play_note (C5_s,2.8f);
		play_note (D5_d,2.9f);
		play_note (E5_f,3.0f);
		play_note (F5_g,3.1f);
		play_note (G5_h,3.2f);
		play_note (A6_j,3.3f);
		play_note (B6_k,3.4f);
		play_note (C6_l,3.5f);
*/



		//Vector3 pos1 = new Vector3 (0.689f,4.77f,0.04f);
		//Instantiate (c5,pos1, transform.rotation);


		//play_note (c5,1.1f);

		//Debug.Log (position);
		//  play_note (a5,1.0f);//working
		//play_note (b5,1.0f);  //wromg
		//play_note (c5,1.0f);//wromg
		//play_note (d5,1.0f);//working
		//play_note (e5,1.0f);//working
		//play_note (f5,1.0f);//working
		//play_note (g5,1.0f);// working
		//play_note (a_sharp_5,1.0f);  //working
		//play_note (c_sharp_5,1.0f);//working
		//play_note (d_sharp_5,1.0f);//working
		//play_note (f_sharp_5,1.0f);	// working
		//play_note (g_sharp_5,1.0f);  // working

	//	play_note (c5,100.0f);
		//play_dhoom();
	}

	/*
	void play_saregama()
	{
		play_note (c5,1.0f);
		play_note (d5,1.2f);
		play_note (e5,1.4f);
		play_note (f5,1.6f);
		play_note (g5,1.8f);
		play_note (b5,2.0f);
		//play_note (c5,1.0f);



	}

	void play_dhoom ()
	{

		play_note (d_sharp_5,1.2f);

		play_note (a_sharp_5,1.4f);

		play_note (g_sharp_5,1.5f);

		play_note (a_sharp_5,1.6f);

		play_note (g_sharp_5,1.7f);

		play_note (a_sharp_5,1.9f);

		play_note (f_sharp_5,2.1f);

		play_note (g_sharp_5,2.3f);

		play_note (a_sharp_5,2.5f);

		play_note (g_sharp_5,2.7f);

		play_note (f_sharp_5,2.9f);

		play_note (f5,3.1f);

		play_note (d_sharp_5,3.2f);


		play_note (a_sharp_5,3.3f);

		play_note (g_sharp_5,3.4f);

		play_note (a_sharp_5,3.5f);

		play_note (g_sharp_5,3.7f);

		play_note (a_sharp_5,3.9f);

		play_note (f_sharp_5,4.1f);

		play_note (g_sharp_5,4.3f);

		play_note (a_sharp_5,4.5f);

		play_note (g_sharp_5,4.7f);










	}

*/

	void play_note(Transform tone,float height)
	{



		/*----------------------------
		 * OCTET 4
		 * -----------------------
		 * 
		 * */


		if(tone == C4_t)
		{
			Vector3 position = Start_Position_C4_t;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);
		}

		else if (tone == D4_y)
		{
			Vector3 position = Start_Position_D4_y;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);

		}


		else if(tone == E4_u)
		{
			Vector3 position = Start_Position_E4_u;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);
		}

		else if (tone == F4_i)
		{
			Vector3 position = Start_Position_F4_i;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);


		}


		else if(tone == G4_o)
		{
			Vector3 position = Start_Position_G4_o;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);
		}



		else if(tone == A5_p)
		{
			Vector3 position = Start_Position_A5_p;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);
		}

		else if (tone == B5_a)
		{
			Vector3 position = Start_Position_B5_a;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);

		}


		/*-------------------------------------------
		 * OCTET 5
		 * ---------------------------------------
		 * 
		 * 
		 * */

		if(tone == C5_s)
		{
			Vector3 position = Start_Position_C5_s;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);


		}

		else if(tone == D5_d)
		{
			Vector3 position = Start_Position_D5_d;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);

		}

		else if(tone == E5_f)
		{
			Vector3 position = Start_Position_E5_f;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);

		}


		else if(tone == F5_g)
		{
			Vector3 position = Start_Position_F5_g;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);

		}


		else if(tone == G5_h)
		{
			Vector3 position = Start_Position_G5_h;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);

		}

		else if(tone == A6_j)

		{
			Vector3 position = Start_Position_A6_j;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);

		}

		else if(tone == B6_k)
		{
			Vector3 position = Start_Position_B6_k;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);

		}





		/* -------------------------------------
		 * OCTET 6
		 * --------------------------------------
		 * */

		else if(tone == C6_l)
		{
			Vector3 position = Start_Position_C6_l;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);

		}
		/*
		else if(tone == g5)
		{
			Vector3 position = Start_Position_g5;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);

		}

		else if(tone == g_sharp_5)
		{
			Vector3 position = Start_Position_g_sharp_5;
			position.y = position.y + height;
			Instantiate (tone,position, transform.rotation);
		}
*/			

	
	}





	void Update()
	{

		//Debug.Log("score" + Bucket_script.score);

		Score_Text.text = Bucket_script.score.ToString ();

		if (Input.GetKeyDown ("p")) {
		
			Application.LoadLevel (0);
			Ground_Dead.dead = false;
		}
	}

	public void Slider_Gravity_Handler()
	{
			

		//Gravity = slider.value;

		Debug.Log ("Slider changed");
	}




}
