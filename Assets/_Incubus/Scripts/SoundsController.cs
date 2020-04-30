using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsController : MonoBehaviour
{
    public AudioSource backgroundMusic, FX;

    [Header("FX Clips")]
    public AudioClip openDoorClip;
    public AudioClip puzzleUnlocked;
    public AudioClip wrong;
    public AudioClip win;
    public AudioClip pieceSlide;
    public AudioClip pieceTrue;
    public AudioClip pieceWrong;
    public AudioClip lightOn;
    [Header("Bacground Music")]
    public AudioClip GameplaySound;
    public void PlayBackgroundMusic()
    {
        backgroundMusic.clip = GameplaySound;
        backgroundMusic.Play();
    }
    
    public void PlayOpenDoorSound()
    {
        FX.clip = openDoorClip;
        FX.Play();
    }
    public void PlayPuzzleUnlockedSound()
    {
        FX.clip = puzzleUnlocked;
        FX.Play();
    }
    public void PlayWrongSound()
    {
        FX.clip = wrong;
        FX.Play();
    }
    public void PlayWinSound()
    {
        FX.clip = win;
        FX.Play();
    }
    public void PlayPieceSlideSound()
    {
        FX.clip = pieceSlide;
        FX.Play();
    }
    public void PlayPieceWrongSound()
    {
        FX.clip = pieceWrong;
        FX.Play();
    }
    public void PlayPieceTrueSound()
    {
        FX.clip = pieceTrue;
        FX.Play();
    }
    public void PlayLightOnSound()
    {
        FX.clip = lightOn;
        FX.Play();
    }
    private void Start()
    {
        PlayBackgroundMusic();
    }
}
