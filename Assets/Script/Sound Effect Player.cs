using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SoundEffectPlayer : MonoBehaviour
{

    public AudioSource SRC;
    public AudioClip sfx1;



    public void Button1()
    {
        SRC.clip = sfx1;
        SRC.Play();
    }

}
