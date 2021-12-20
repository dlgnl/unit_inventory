using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapons_UI : MonoBehaviour
{
    int i;
    int z,e = -1;
    public GameObject[] swap_item;
    int weaponIndex;
    public int UI;
    public void item_UI(){
      ItemPickup1 cinputmovement = GameObject.Find("player").GetComponent<ItemPickup1>();
      Weapons_UI2 weapons_UI2 = GameObject.Find("1번 2").GetComponent<Weapons_UI2>();
      Weapons_UI3 weapons_UI3 = GameObject.Find("1번 3").GetComponent<Weapons_UI3>();
      z = e;
      int a = cinputmovement.num;
      int b = cinputmovement.i;
      e = cinputmovement.c;
      int ak = cinputmovement.one;
      int UI2 = weapons_UI2.UI2;
      int UI3 = weapons_UI3.UI3;
      int UI = ak;

      if(a == 1 || b == 1){
        if(Input.GetKey(KeyCode.Z)){
          if(b == 1){ 
              Debug.Log("!");
              for(i = 0;i<8;i++){
                swap_item[i].SetActive(false);
                }
              swap_item[e].SetActive(true);
              
          }
            Debug.Log(e);
            for(i = 0;i<8;i++){
                swap_item[i].SetActive(false);
                }
            swap_item[ak].SetActive(true);
            z = e;
        }
      }
        
    }
    void Update()
    {
        item_UI();
    }
}
