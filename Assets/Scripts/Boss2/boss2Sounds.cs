using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2Sounds : MonoBehaviour
{
    
    public static AudioClip welcome, laugh, death, die, magicblade;
    private static AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        welcome = Resources.Load<AudioClip>("267399__viznoman__welcome-to-hell-demon-voice");
        laugh = Resources.Load<AudioClip>("587951__noahbangs__demon-laugh-1");
        death = Resources.Load<AudioClip>("56304__syna-max__monster-death-scream");
        die = Resources.Load<AudioClip>("588668__thepig01__you-will-die");
        magicblade = Resources.Load<AudioClip>("563332__badoink__magic-blade");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "267399__viznoman__welcome-to-hell-demon-voice":
                _audioSource.PlayOneShot(welcome);
                break;
            
            case "587951__noahbangs__demon-laugh-1":
                _audioSource.PlayOneShot(laugh);
                break;
            
            case "56304__syna-max__monster-death-scream":
                _audioSource.PlayOneShot(death);
                break;
            
            case "588668__thepig01__you-will-die":
                _audioSource.PlayOneShot(die);
                break;
            
            case "563332__badoink__magic-blade":
                _audioSource.PlayOneShot(magicblade);
                break;
            
            
        }
    }
}
