using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public AudioSource SuaraVoiceOver;

//    JoinRoom joinRoom = gameObject.GetComponent<AudioSource>();

    void Awake()
    {
        SuaraVoiceOver = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // joinRoom.audioactive.volume = 0.15f;
            SuaraVoiceOver.enabled = true;
            SuaraVoiceOver.Play();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SuaraVoiceOver.enabled = false;
            SuaraVoiceOver.Stop();
            // joinRoom.audioactive.volume = 0.55f;
        }
    }

}
