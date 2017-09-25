using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {


   public Vector2 jumpforce = new Vector2 (300,0);
 public Vector2 axis = new Vector2 (300,0);
 Rigidbody2D rB2D;

public int i=0;
	// Use this for initialization
	void Start () {
		 rB2D = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKeyUp("space"))
		{
 
if(i%2==0){


rB2D.velocity=Vector2.zero;
rB2D.AddForce(jumpforce);
i++;
}
else
{
rB2D.velocity=Vector2.zero;
rB2D.AddForce(axis);
i++;


}

}
Vector2 screenPosition= Camera.main.WorldToScreenPoint(transform.position);



if(screenPosition.x >4 || screenPosition.x <-4)
{



}
}




		}
		
	

