using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CompPass : MonoBehaviour
{
    public string Password;
    public InputField input_Password;

    public void CheckPass()
    {
        if (Password == input_Password.text)
        {
            Debug.Log("Access Granted");
        }
        else
        {
            Debug.Log("Access denied");
        }
    }
}
