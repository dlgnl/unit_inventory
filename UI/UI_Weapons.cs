using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Weapons : MonoBehaviour
{
    GameObject nearObject;
    int i;
    public int s;
    Weapons_UI wp;

    public void UI_wp(){
        if(Input.GetKey(KeyCode.Z)){
            if(nearObject != null){
              if(nearObject.tag == "Weapon") {
                i++;
                Debug.Log("메롱");
                wp.transform.GetChild(i).gameObject.SetActive(false);
            
        }
    }
        }
    }

    void Start()
    {
        
    }
    void Update()
    {
        UI_wp();
    }
}
