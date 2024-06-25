using UnityEngine;

public class MainSoundManager : MonoBehaviour
{
    public static MainSoundManager instance;

    [Range(0f, 1f)] public float soundEffectVolume;
    [SerializeField][Range(0f, 1f)] private float soundEffectPitchVariance;
    [Range(0f, 1f)] public float musicVolume;

    private AudioSource musicAudioSource;
    public AudioClip musicClip;

    private void Awake()
    {
        instance = this;
        musicAudioSource = GetComponent<AudioSource>();
        musicAudioSource.volume = musicVolume;
        musicAudioSource.loop = true;
    }

    private void Start()
    {
        ChangeBackGroundMusic(musicClip);
    }

    public static void ChangeBackGroundMusic(AudioClip music)
    {
        instance.musicAudioSource.Stop();
        instance.musicAudioSource.clip = music;
        instance.musicAudioSource.Play();
    }

    public void ChangeBGMVolume()
    {
        musicAudioSource.volume = musicVolume;
    }

    public static void PlayClip(AudioClip clip)
    {
        GameObject obj = GameManager.Instance.ObjectPool.SpawnFromPool("SoundSource");
        obj.SetActive(true);
        SoundSource soundSource = obj.GetComponent<SoundSource>();
        soundSource.Play(clip, instance.soundEffectVolume, instance.soundEffectPitchVariance);
    }
}
