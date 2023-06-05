using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource nope;
    public AudioSource affirmative;
    public AudioSource switching;

    public void PlayNope()
    {
        nope.Play();
    }
    public void PlayAffirmative()
    {
        affirmative.Play();
    }
    public void PlaySwitching()
    {
        switching.Play();
    }

}
