using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private GameObject gameOverPanel;

    private IHittableCharacter hittableCharacter;

    private void Awake()
    {
        gameOverPanel.SetActive(false);
    }

    private void Start()
    {
        hittableCharacter = player.GetComponent<IHittableCharacter>();

        hittableCharacter.Ondead += HittableCharacter_Ondead;
    }

    private void HittableCharacter_Ondead()
    {
        gameOverPanel.SetActive(true);
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    
}
