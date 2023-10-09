using UnityEngine;

public class PlayerSounds : Audio
{
    [SerializeField] private int _maxAmountSounds;

    private const string _TANK_IS_RUNNING_SOUND_PATH = "Sounds/Tanks/TankIsRunning";
    private const string _TANK_IS_MOVING_SOUND_PATH = "Sounds/Tanks/TankIsMoving";
    private const string _TANK_IS_START_MOVING_SOUND_PATH = "Sounds/Tanks/TankIsStartMoving";
    private const string _TANK_START_UP = "Sounds/Tanks/TankStartUp";

    private string _indexSound;

    public override void Initialize()
    {
        _indexSound = Random.Range(1, _maxAmountSounds).ToString();
        SoundStartUp();
        SoundRunning();
    }

    private void SoundStartUp()
    {
        AudioClip audioClip = (AudioClip)Resources.Load(_TANK_START_UP + _indexSound);
        PlaySound(audioClip);
    }

    private void SoundStartMoving()
    {
        AudioClip audioClip = (AudioClip)Resources.Load(_TANK_IS_START_MOVING_SOUND_PATH + _indexSound);
        PlaySound(audioClip);
    }

    public void SoundRunning()
    {
        AudioClip audioClip = (AudioClip)Resources.Load(_TANK_IS_RUNNING_SOUND_PATH + _indexSound);
        PlayMusic(audioClip);
        print("run");
    }

    public void SoundMoving()
    {
        SoundStartMoving();
        AudioClip audioClip = (AudioClip)Resources.Load(_TANK_IS_MOVING_SOUND_PATH + _indexSound);
        PlayMusic(audioClip); 
        print("move");
    } 
}   
