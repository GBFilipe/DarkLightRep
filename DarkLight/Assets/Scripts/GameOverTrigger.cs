using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverTrigger : MonoBehaviour
{

    public TextMeshProUGUI gameOver;
    public Button QuitButton;
    public Button RestartButton;
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        RestartButton.onClick.AddListener(RestartGame);
    }

    // Update is called once per frame
    void Update()
    { 
    
    }

    
    private void OnTriggerEnter(Collider other)
    {
     
        if (!isGameOver) 
        {
            SceneManager.LoadScene("GameOver");

            if (gameOver != null)
            {
                gameOver.gameObject.SetActive(true);

            }

            // Activate Quit and Restart Buttons
           
            if (QuitButton != null)
            {
                QuitButton.gameObject.SetActive(true);
            }

            if (RestartButton != null)
            {
                RestartButton.gameObject.SetActive(true);

            }

        }
    }
    
    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);

    }

}