using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button_Handler : MonoBehaviour {

	public Slider slider;

	public void DoSomething()
	{

		Application.LoadLevel (0);
		Ground_Dead.dead = false;
		Debug.Log ("Button is pressed");
	}

	public  void Slider_Gravity_Handler()
	{
		Debug.Log ("slider changed"+slider.value);
	//	Physics.gravity = new Vector3(0, -1*slider.value, 0);
	}




}
