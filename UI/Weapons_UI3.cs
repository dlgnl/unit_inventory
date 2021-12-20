using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons_UI3 : MonoBehaviour
{
    int i;
    int z,e = -1;
    public GameObject[] swap_item;
    public int UI3;
    public void item_UI(){
      ItemPickup1 cinputmovement = GameObject.Find("player").GetComponent<ItemPickup1>();
      Weapons_UI weapons_UI = GameObject.Find("1번 1").GetComponent<Weapons_UI>();
      Weapons_UI2 weapons_UI2 = GameObject.Find("1번 2").GetComponent<Weapons_UI2>();
      int a = cinputmovement.num;
      int b = cinputmovement.i;
      e = cinputmovement.c;
      int ak = cinputmovement.tre;
      UI3 = ak;
      int UI2 = weapons_UI2.UI2;
      int UI = weapons_UI.UI;
      if(a == 3 || b == 3){
        if(Input.GetKey(KeyCode.Z)){
            if(b ==3){
                Debug.Log("!");
                for(i = 0;i<8;i++){
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
