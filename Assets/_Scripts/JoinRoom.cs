using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinRoom : MonoBehaviour
{
    public GameObject PanelMainMenu, PanelPilihChar, CameraUIChar, ImageBestari, ExitButton;

    public GameObject BoyChar, GirlChar;

    public AudioSource audioactive;
    public AudioClip menuAudio, GameAudio;

    private void Start() {
        audioactive.clip = menuAudio;
        audioactive.Play();
    }

    public void OnMainMenuClicked()
    {
        PanelMainMenu.SetActive(false);
        PanelPilihChar.SetActive(true);
    }

    public void OnPilihBoyCharClicked()
    {
        PanelPilihChar.SetActive(false);
        BoyChar.SetActive(true);
        GirlChar.SetActive(false);
        CameraUIChar.SetActive(false);
        ImageBestari.SetActive(false);
        ExitButton.SetActive(true);
        audioactive.Stop();
        audioactive.clip = GameAudio;
        audioactive.volume = 0.25f;
        audioactive.Play();
    }

    public void OnPilihGirlCharClicked()
    {
        PanelPilihChar.SetActive(false);
        BoyChar.SetActive(false);
        GirlChar.SetActive(true);
        CameraUIChar.SetActive(false);
        ImageBestari.SetActive(false);
        ExitButton.SetActive(true);
        audioactive.Stop();
        audioactive.clip = GameAudio;
        audioactive.volume = 0.25f;
        audioactive.Play();
    }  

    public void onExitClicked()
    {
        Application.Quit();
        Debug.Log("Berhasil Exit");
    }

    private void update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            CameraUIChar.SetActive(true);
            ImageBestari.SetActive(true);
            PanelMainMenu.SetActive(true);
            BoyChar.SetActive(false);
            GirlChar.SetActive(false);
            ExitButton.SetActive(false);
            Debug.Log("Berhasil Back");
            audioactive.Stop();
            audioactive.clip = menuAudio;
            audioactive.volume = 1f;
            audioactive.Play();
        }
    }

    public void onBackClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
