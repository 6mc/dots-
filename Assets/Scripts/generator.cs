using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour {


public GameObject boxes;


	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
		

	}
	

void CreateObstacle()
{

//Instantiate(boxes);

Instantiate(boxes, GeneratedPosition(), Quaternion.identity);

}


	// Update is called once per frame
	void Update () {
		
	}



Vector2 GeneratedPosition()
{
 int x,y,z;
 x = Random.Range(-6,6);
 y = Random.Range(7,8);

 return new Vector2(x,y);
}














}
