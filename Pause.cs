using Unity.VisualScripting;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public Transform pause;
    public GameObject pauseButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)){
            if(pause.gameObject.activeSelf){
                pause.gameObject.SetActive(false);
                Time.timeScale = 1;
                pauseButton.SetActive(true);
            }else{
                pause.gameObject.SetActive(true);
                pauseButton.SetActive(false);
                Time.timeScale = 0;
            }
        }
        if(pause.gameObject.activeSelf){
            pauseButton.SetActive(false);
        }
        if(!pause.gameObject.activeSelf)
        {
            pauseButton.SetActive(true);
        }
        
        
    
    }
    public void Resume(){
        pause.gameObject.SetActive(false);
        Time.timeScale = 1;
        pauseButton.SetActive(true);
    }
    public void Quit(){
        Application.Quit();
    }
    //public void Restart()
    //{
    //    UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    //    Time.timeScale = 1;
    //}
    //public void MainMenu()
    //{
    //    UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    //    Time.timeScale = 1;
    //}
    public void Pausar(){
        pause.gameObject.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
    }
}