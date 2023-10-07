using UnityEngine;

public class PlayerSounds : Audio
{
    [SerializeField] private int _maxAmountSounds;

    private const string _TANK_IS_RUNNING_SOUND_PATH = "Sounds/Tanks/TankIsRunning";
    private const string _TANK_IS_MOVING_SOUND_PATH = "Sounds/Tanks/TankIsMoving";
    private const string _TANK_START_UP = "Sounds/Tanks/TankStartUp";

    private string _indexSound;

    public override void Initialize()
    {
        _indexSound = Random.Range(1, _maxAmountSounds).ToString();
        SoundRunning();
    }

    public void SoundRunning()
    {
        AudioClip currentAudioClip = (AudioClip)Resources.Load(_TANK_IS_RUNNING_SOUND_PATH + _indexSound);
        PlayMusic(currentAudioClip);
        print("run");
    }

    public void SoundMoving()
    {
        AudioClip currentAudioClip = (AudioClip)Resources.Load(_TANK_IS_MOVING_SOUND_PATH + _indexSound);
        PlayMusic(currentAudioClip); 
        print("move");
    } 
}   
