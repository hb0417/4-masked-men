using UnityEngine;
using UnityEngine.UI;


public class SoundSlide : MonoBehaviour
{
    [SerializeField] private Slider bgmSlider;
    [SerializeField] private Slider sfxSlider;

    private void Start()
    {
        bgmSlider.value = MainSoundManager.instance.musicVolume;
        sfxSlider.value = MainSoundManager.instance.soundEffectVolume;

        bgmSlider.onValueChanged.AddListener(OnBGMSliderValueChanged);
        sfxSlider.onValueChanged.AddListener(OnSFXSliderValueChanged);
    }

    private void OnSFXSliderValueChanged(float value)
    {
        MainSoundManager.instance.soundEffectVolume = value;
    }

    private void OnBGMSliderValueChanged(float value)
    {
        MainSoundManager.instance.musicVolume = value;
        MainSoundManager.instance.ChangeBGMVolume();
    }
}