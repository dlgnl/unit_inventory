using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup1 : MonoBehaviour
{
    public int c;
   GameObject nearObject;
    public GameObject[] weapons;
    public bool[] hasWeapons;
    public int itemID;
    public int one,two,tre;
    public int i=0;
    public int num = 0;
    public bool[] swap = new bool[4];
   void  Update(){
     pickup();
     swich();
    }
    private void OnTriggerStay2D(Collider2D collision)
   {
      if(collision.tag == "Weapon"){
        Debug.Log("dkdkdkdkd");
        nearObject = collision.gameObject;}
   }
  
   private void OnTriggerExit2D(Collider2D collision) 
   {
      if (collision.gameObject.tag == "Weapon"){
        Debug.Log("rfgalskjfhslkfdj");
        nearObject = null;}
   }

   void swich(){
      if(Input.GetKey(KeyCode.Alpha1)){
        if(swap[1] == true){
          weapons[one].SetActive(true);
          weapons[two].SetActive(false);
          weapons[tre].SetActive(false);
          num = 1;
       }
     }
      if(Input.GetKey(KeyCode.Alpha2)){
        if(swap[2] == true){
           weapons[one].SetActive(false);
           weapons[two].SetActive(true);
           weapons[tre].SetActive(false);
            num = 2;
       }
     }
      if(Input.GetKey(KeyCode.Alpha3)){
         if(swap[3] == true){
           weapons[one].SetActive(false);
           weapons[two].SetActive(false);
           weapons[tre].SetActive(true);
           num = 3;
       }
     }
   } 
     private void pickup(){
        if(Input.GetKey(KeyCode.Z)){
          Debug.Log("가");
            if(nearObject != null){
              Debug.Log("나");
              if(nearObject.tag == "Weapon") {
                if(i<3){
                  weapons[c].SetActive(false);
                 item item = nearObject.GetComponent<item>();
                 int weaponIndex = item.value;
                 weapons[weaponIndex].SetActive(true);
                 Destroy(nearObject);
                 i++;
                 c = weaponIndex;
                 swap[i] = true;
                 if(i == 1){
                   one = weaponIndex;
                 }
                 if(i == 2){
                   two = weaponIndex;
                 }
                 if(i == 3){
                   tre = weaponIndex;
                 }
                 }
                else if(num == 1){
                   weapons[one].SetActive(false);
                   item item = nearObject.GetComponent<item>();
                  int weaponIndex = item.value;
                  one = weaponIndex;
                  c = weaponIndex;
                  Destroy(nearObject);
                  weapons[one].SetActive(true);
                 }
                else if(num == 2){
                   weapons[two].SetActive(false);
                   item item = nearObject.GetComponent<item>();
                  int weaponIndex = item.value;
                  two = weaponIndex;
                  c = weaponIndex;
                  Destroy(nearObject);
                  weapons[two].SetActive(true);
                 }
                else if(num == 3){  
                   weapons[tre].SetActive(false);
                   item item = nearObject.GetComponent<item>();
                  int weaponIndex = item.value;
                  tre = weaponIndex;
                  c = weaponIndex;
                  Destroy(nearObject);
                  weapons[tre].SetActive(true);
                 }   
        }
      }
        }
    }
}
