using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
   public AudioMixer audioMixer;    // ���п��Ƶ�Mixer����
 
    public void SetMasterVolume(float volume)    // �����������ĺ���
    {
        audioMixer.SetFloat("MasterVolume", volume);
        // MasterVolumeΪ���Ǳ�¶������Master�Ĳ���
    }
 
    public void SetMusicVolume(float volume)    // ���Ʊ������������ĺ���
    {
        audioMixer.SetFloat("MusicVolume", volume);
        // MusicVolumeΪ���Ǳ�¶������Music�Ĳ���
    }
 
    public void SetSoundEffectVolume(float volume)    // ������Ч�����ĺ���
    {
        audioMixer.SetFloat("SoundEffectVolume", volume);
        // SoundEffectVolumeΪ���Ǳ�¶������SoundEffect�Ĳ���
    }
}
