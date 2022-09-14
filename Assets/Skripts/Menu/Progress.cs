using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{

    public static Progress Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            Load();
        }
        else {
            Destroy(gameObject);
        }
    }

    private void Load() {
        _coins = PlayerPrefs.GetInt("COINS", 0);
        _musicVolume = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
    }

    [SerializeField] private int _coins;
    public int Coins
    {
        get { return _coins; }
        set
        {
            PlayerPrefs.SetInt("COINS", value);
            _coins = value;
        }
    }

    [SerializeField] private float _musicVolume;
    public float MusicVolume
    {
        get { return _musicVolume; }
        set
        {
            PlayerPrefs.SetFloat("MusicVolume", value);
            _musicVolume = value;
        }
    }

}
