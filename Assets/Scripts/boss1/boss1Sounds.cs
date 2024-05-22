using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss1Sounds : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip scream, cosmos, death;
    private static AudioSource _audioSource;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        scream = Resources.Load<AudioClip>("333832__nick121087__demonic-woman-scream");
        cosmos = Resources.Load<AudioClip>("219782__madamvicious__feel-the-fury-of-the-cosmos-mortal");
        death = Resources.Load<AudioClip>("177429__andromadax24__s-death-slith-08");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "333832__nick121087__demonic-woman-scream":
                _audioSource.PlayOneShot(scream);
                break;
            
            case "219782__madamvicious__feel-the-fury-of-the-cosmos-mortal":
                _audioSource.PlayOneShot(cosmos);
                break;
            
            case "177429__andromadax24__s-death-slith-08":
                _audioSource.PlayOneShot(death);
                break;
            
            
        }
    }
}
