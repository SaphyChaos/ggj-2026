using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip BackgroundMusicClip;

    [SerializeField]
    private AudioSource AudioSource;

    void Awake() {
        AudioSource.clip = BackgroundMusicClip;
        AudioSource.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
