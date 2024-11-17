using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private AudioSource music;

    private void Awake()
    {
        // Cek apakah ada instance lain dari GameObject ini
        if (FindObjectsOfType<Music>().Length > 1)
        {
            Destroy(gameObject); // Hapus duplikasi GameObject backsound
        }
        else
        {
            DontDestroyOnLoad(gameObject); // Pastikan GameObject ini tidak dihancurkan saat berpindah scene
        }
    }

    public void OnMusic()
    {
        music.Play();
    }

    public void OffMusic()
    {
        music.Stop();
    }
}
