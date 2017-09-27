using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;  
using System;
using UnityEngine.UI;
using System.Linq;





public class Destroyer : MonoBehaviour {

public Text puan;

public int i=0;


void OnCollisionEnter2D(Collision2D col) {
 //her hangi bir objeye çarptığında çalışır
 if (col.gameObject.name == "kutu(Clone)" ) {
 //tagı Cupe olan bir objeye çarptığında çalışır

i=i+100; 
puan.text=i.ToString();
Destroy(col.gameObject);
 }
 

 }







}
