using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class JumpButtonScripts : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
    
    public void OnPointerDown(PointerEventData data)
    {
        if (PlayerJumpScript.instance != null)
        {

            Debug.Log("1");
            PlayerJumpScript.instance.SetPower(true);
        }
    }


    public void OnPointerUp(PointerEventData data)
    {
        if (PlayerJumpScript.instance != null)
        {

            Debug.Log("2");

            PlayerJumpScript.instance.SetPower(false);
        }
    }
    



}


