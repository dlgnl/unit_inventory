using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons_UI2 : MonoBehaviour
{
    int z,e = -1;
    int i;
   public GameObject[] swap_item;
    public int UI2;
    public void item_UI(){
      ItemPickup1 cinputmovement = GameObject.Find("player").GetComponent<ItemPickup1>();
      Weapons_UI weapons_UI = GameObject.Find("1번 1").GetComponent<Weapons_UI>();
      Weapons_UI3 weapons_UI3 = GameObject.Find("1번 3").GetComponent<Weapons_UI3>();
      int a = cinputmovement.num;
      int b = cinputmovement.i;
      e = cinputmovement.c;
      int ak = cinputmovement.two;
      UI2 = ak;
      int UI = weapons_UI.UI;
      int UI3 = weapons_UI3.UI3;
      if(a == 2 || b == 2){
        if(Input.GetKey(KeyCode.Z)){
            if(b == 2){
                Debug.Log("!");
                for(i=0;i<8;i++){
                    swap_item[i].SetActive(false);
                }
                swap_item[e].SetActive(true);
            }
               Debug.Log("e");
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