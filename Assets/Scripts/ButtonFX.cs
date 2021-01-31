using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFX : MonoBehaviour
{
    public AudioSource source;
    public AudioClip hoverSound;
    public AudioClip clickSound;

    public void HoverSound()
    {
    	source.PlayOneShot(hoverSound);
    }
    public void ClickSound()
    {
    	source.PlayOneShot(clickSound);
    }
}
