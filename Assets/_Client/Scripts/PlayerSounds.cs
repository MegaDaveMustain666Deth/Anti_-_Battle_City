using UnityEngine;

public class PlayerSounds : Audio
{
    private const string _TANK_IS_RUNNING_SOUND_PATH = "Sounds/Tanks/TunkIsRunning";
    private const string _TANK_START_UP = "Sounds/Tanks/TankStartUp";

    public override void Initialize()
    {
        base.Initialize();
        AudioClip currentAudioClip = (AudioClip)Resources.Load(_TANK_START_UP + Random.Range(1, 2).ToString());
        PlayMusic(currentAudioClip);
        PlayMusicDelayed((AudioClip)Resources.Load(_TANK_IS_RUNNING_SOUND_PATH + Random.Range(1, 2).ToString()), currentAudioClip.length);
        print(_TANK_IS_RUNNING_SOUND_PATH + Random.Range(1, 2).ToString());
        Player.Instance.OnMove += SoundMove;
    }

    private void SoundMove()
    {
        // AudioClip currentAudioClip = (AudioClip)Resources.Load(_TANK_IS_RUNNING_SOUND_PATH + Random.Range(1, 2).ToString());
        // PlaySound(currentAudioClip);
    } 
}   
