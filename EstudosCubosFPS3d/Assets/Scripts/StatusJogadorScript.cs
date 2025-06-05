using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StatusJogadorScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int quantidadeMaximaVidas = 5;
    int vidas;
    void Start()
    {
        this.vidas = quantidadeMaximaVidas;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void removeVida()
    {
        vidas--;
        Debug.Log("Apanhei dos cubos! Vidas restantes: " + vidas);
        if (vidas <= 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene("CenaGameOver");
        }
    }
}
