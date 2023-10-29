
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;

    public AudioClip background;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }
}
