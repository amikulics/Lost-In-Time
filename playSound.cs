using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour
{
    //does same thing as coin pickup but with generic names
    public AudioSource soundEffect;

    public void playSoundEffect()
    {
        soundEffect.Play();
    }
}
