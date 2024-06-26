using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayIdleAudio : MonoBehaviour
{
    [SerializeField] private AudioSource mIdleAud;

    public void PlayAudio()
    {
        mIdleAud.Play();
    }
}
