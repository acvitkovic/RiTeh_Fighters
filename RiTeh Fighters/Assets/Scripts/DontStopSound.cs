using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class DontStopSound : MonoBehaviour
{

    public void Awake()
    {

        DontDestroyOnLoad(transform.gameObject);
    }
}
