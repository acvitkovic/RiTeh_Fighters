using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CancelBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (GameObject.FindGameObjectWithTag("CancelBtn2") != null)
            {
                GameObject.FindGameObjectWithTag("CancelBtn2").GetComponent<CustomButton>().onClick.Invoke();
            } else
            {
                GameObject.FindGameObjectWithTag("CancelBtn").GetComponent<CustomButton>().onClick.Invoke();
            }
        }
    }
}
