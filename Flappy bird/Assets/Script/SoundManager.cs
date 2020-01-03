using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager soundManager = null;
    [SerializeField] private AudioClip audioBridDie;
    [SerializeField] private AudioClip audioBridSorce;
    [SerializeField] private AudioClip audioFlappBrid;
    [SerializeField] private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        if (soundManager == null)
        {
            soundManager = this;
        }
        else if(soundManager != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void BirdDead() {
        audioSource.PlayOneShot(audioBridDie);
    }
    public void BridSorce() {
        audioSource.PlayOneShot(audioBridSorce);
    }
    public void FlappBrid() {
        audioSource.PlayOneShot(audioFlappBrid);
    }

}
