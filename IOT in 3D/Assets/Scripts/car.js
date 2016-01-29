#pragma strict


public var car: Transform;
                   
public var response;
public var  last_response;
public var welcome_sound : Transform;

//public var one_spot : Transform;

public var text: UnityEngine.UI.Text;
function Start () 
{

	Instantiate(welcome_sound);
	//yield WaitForSeconds (5);
	//Instantiate(one_spot);
	car.position.y=20;	
}

function Update () 
{
	send(1);
	if(response=='s')
	{
		show_car();
		last_response = 's';
		Global_prog.spots ="0";


	}
	else if(response=='h')
	{
		hide_car();
		last_response = 'h';
			Global_prog.spots ="1";
		                                                                                                          
	}
	else
	{
		if(last_response=='s')
		{
			car.position.y=-4;
		}
		else if(last_response=='h')
		{
			car.position.y = 20;

		}


	}
	//Debug.Log("spots:");
		Debug.Log(Global_prog.spots);
		text.text =  Global_prog.spots;

}

function show_car()
{
	var i:float;
	for(i=6;i<10;i=i+0.2)
	{
		car.position.y=6-i;
		yield WaitForSeconds (0.001);
	}

}

function hide_car()
{
		car.position.y=20;
	

}


function send(data:int) 
{
    var form = new WWWForm();
    form.AddField("action", "send");
    //form.AddField("light_status", data);
    var url = "http://192.168.43.235/send.php?light_status="+data;
    var www = WWW(url, form);
    yield www;
    //Debug.Log("response is --->");
    Debug.Log(www.text);
    response = www.text;
    //Game_Master.Response =www.text;
    //yield WaitForSeconds (1);
 }
