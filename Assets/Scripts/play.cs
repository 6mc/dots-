using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour {

public GameObject res;
public GameObject over;	
public int i=0;


void OnCollisionEnter2D(Collision2D col) {
 //her hangi bir objeye çarptığında çalışır
 if (col.gameObject.tag == "Finish" ) {
 //tagı Cupe olan bir objeye çarptığında çalışır
 
//Debug.Log("asarak"+i);
 
//i++;
res.SetActive(true);
over.SetActive(true);

 Time.timeScale = 0.0F;


 }




 

 }






}
