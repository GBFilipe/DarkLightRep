using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public TextMeshProUGUI gameOver;
    public Button RestartButton;
    public Button QuitButton;
    public bool isGameActive;
    
    
    
    
    public Tile middle;
    public Tile right;
    public Tile left;
    public int WhiteTile;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangeTiles", 2, 2);
        StartCoroutine(FlashRed());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void GameOver()
    {
        RestartButton.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }




    void ChangeTiles()
    {
        
        switch (WhiteTile) 
        {
            case 1:
                middle.Black();
                right.Black();
                left.White();
                     break;
            case 2:
                middle.White();
                right.Black();
                left.Black();
                break;
            case 3:
                middle.Black();
                right.White();
                left.Black();
                break;
        }
    
    
    }

    IEnumerator FlashRed()
    {
        yield return new WaitForSeconds(1);
        WhiteTile = Random.Range(1, 4);

        switch (WhiteTile)
        {
            case 1:


                left.StartCoroutine("ChangeColor");
                break;
            case 2:
                middle.StartCoroutine("ChangeColor");


                break;
            case 3:
                
                right.StartCoroutine("ChangeColor");

                break;
        }
        
        yield return new WaitForSeconds(2);
        StartCoroutine("FlashRed");
    }

}
