using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorOnImage : MonoBehaviour {
    public AudioSource SoundSource;
    public AudioClip sound;

    public void OnImage()
    {
        SoundSource.PlayOneShot(sound);
    }

    public void OffImage()
    {
        SoundSource.Stop();
    }

}
