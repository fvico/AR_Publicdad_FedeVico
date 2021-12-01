using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField]
    private List<AudioClip> _listAudios;

    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayClick()
    {
        _audioSource.Stop();
        _audioSource.clip = _listAudios[0];
        _audioSource.Play();
    }
    public void PlayClickArrow()
    {
        _audioSource.Stop();
        _audioSource.clip = _listAudios[1];
        _audioSource.Play();
    }

    private IEnumerator CoPlayKeyBoardWriting()
    {
        yield return new WaitForSeconds(0.6f);
        _audioSource.clip = _listAudios[2];
        _audioSource.Play();
    }

    public void PlayKeyBoardWriting()
    {
        _audioSource.Stop();
        StartCoroutine(CoPlayKeyBoardWriting());
    }

    private IEnumerator CoPlayOpenCan()
    {
        yield return new WaitForSeconds(0.89f);
        _audioSource.Stop();
        _audioSource.clip = _listAudios[3];
        _audioSource.Play();
    }

    public void PlayOpenCan()
    {
        StartCoroutine(CoPlayOpenCan());
    }

    public void StopAllSfx()
    {
        _audioSource.Stop();
    }
}
