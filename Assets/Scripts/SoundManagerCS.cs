using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerCS : MonoBehaviour
{

    public static AudioClip slash1, slash2, slash3, slash4, slash5, slash6;
    private static AudioSource _audioSource;
    
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        slash1 = Resources.Load<AudioClip>("langerium-air-cut");
        slash2 = Resources.Load<AudioClip>("merrick079-sword-sound-1");
        slash3 = Resources.Load<AudioClip>("merrick079-sword-sound-2");
        slash4 = Resources.Load<AudioClip>("misscellany-metallic-whoosh");
        slash5 = Resources.Load<AudioClip>("neospica-knife-slice");
        slash6 = Resources.Load<AudioClip>("neospica-slicing-through-flesh");
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            /*case "langerium-air-cut":
                _audioSource.PlayOneShot(slash1);
                break;*/
            case "merrick079-sword-sound-1":
                _audioSource.PlayOneShot(slash2);
                break;
            case "merrick079-sword-sound-2":
                _audioSource.PlayOneShot(slash3);
                break;
            // Bu ses çalışmadı
            /*case "misscellany-metallic-whoosh":
                _audioSource.PlayOneShot(slash4);
                break;*/
            case "neospica-knife-slice":
                _audioSource.PlayOneShot(slash5);
                break;
            /*case "neospica-slicing-through-flesh":
                _audioSource.PlayOneShot(slash6);
                break; */
        }
    }
}
