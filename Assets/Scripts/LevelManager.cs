using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public GameObject SpawnPoint;

    static int score = 0;

    public Text scoreText;

    public GameObject pauseMenu;

    public GameObject OptionsMenu;

    static bool pause;

    static bool optiM;

    static bool returnb;

    public AudioSource ThemeSong;

    public AudioSource Victory;

    public Slider Volume;

    public static bool Retub
    {
        get { return returnb; }
        set { returnb = value; }
    }

    public static bool OptiM
    {
        get { return optiM; }
        set { optiM = value; }
    }

    public static int Score
    {
        get { return score; }
        set { score = value; }
    }

    public static bool Pause
    {
        get { return pause; }
        set { pause = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        Volume.value = 0.5f;
        ThemeSong.volume = 0.5f;

        score = 0;
        Time.timeScale = 1.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }

        if (scoreText)
        {
            scoreText.text = " Puntaje: " + score.ToString();
        }

    }

    public void TogglePause()
    {

        Victory.Play();

        if (pauseMenu)
        {

            pauseMenu.SetActive(!pauseMenu.activeSelf);
            pause = pauseMenu.activeSelf;
            Time.timeScale = pauseMenu.activeSelf ? 0.0f : 1.0f;
            
        } 
    }

    public void ToggleOptions()
    {
        if(OptionsMenu)
        {
            pauseMenu.SetActive(false);
            OptionsMenu.SetActive(!OptionsMenu.activeSelf);
            OptiM = OptionsMenu.activeSelf;

            Time.timeScale = OptionsMenu.activeSelf ? 0.0f : 1.0f;

        }
    }

    public void ToggleReturn()
    {
        OptionsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ChangeVolume()
    {
        if(ThemeSong && Volume)
        {
            ThemeSong.volume = Volume.value;
        }
        
    }

}
