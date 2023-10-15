using UnityEngine;

public class TankSounds : Audio
{
    [SerializeField] private int _maxAmountSounds;

    private const string _TANK_IS_RUNNING_SOUND_PATH = "Sounds/Tanks/TankIsRunning";
    private const string _TANK_IS_MOVING_SOUND_PATH = "Sounds/Tanks/TankIsMoving";
    private const string _TANK_IS_START_MOVING_SOUND_PATH = "Sounds/Tanks/TankIsStartMoving";
    private const string _TANK_START_UP = "Sounds/Tanks/TankStartUp";
    private const string _TANK_FIRE = "Sounds/Tanks/TankFire1";

    private string _indexSound;

    public override void Initialize()
    {
        _indexSound = Random.Range(1, _maxAmountSounds).ToString();
        SoundStartUp();
        SoundRunning();
        Player.Instance.OnShoot += SoundShoot;
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

    public void SoundShoot()
    {
        AudioClip audioClip = (AudioClip)Resources.Load(_TANK_FIRE);
        PlaySound(audioClip);
    }
}   
