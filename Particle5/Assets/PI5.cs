using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PI5 : MonoBehaviour
{
    public GameObject particleGameObject;
    bool isActive;

    public void ActivateLog(InputAction.CallbackContext context)
    {
        Debug.Log("It works");
        particleGameObject.SetActive(!isActive);
    }
}
