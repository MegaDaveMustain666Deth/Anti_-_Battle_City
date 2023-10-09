using System.Collections;
using UnityEngine;

public abstract class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioSource _musicSource;

    public abstract void Initialize();
    
    protected void PlayMusic(AudioClip clip)
    {
        _musicSource.clip = clip;
        _musicSource.Play();
    }

    protected void PlayMusicDelayed(AudioClip clip, float delay)
    {
        _audioSource.PlayDelayed(delay);
        PlayMusic(clip);
    }

    private IEnumerator SetDelay(float delay, AudioClip clip)
    {
        yield return new WaitForSeconds(delay);
        PlayMusic(clip);
    }

    protected void PlaySound(AudioClip audioClip)
    {
        _audioSource.PlayOneShot(audioClip);
    }
}