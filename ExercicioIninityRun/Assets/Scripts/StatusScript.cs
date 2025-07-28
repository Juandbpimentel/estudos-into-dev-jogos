using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Statuscript : MonoBehaviour
{
    int numeroVidas = 0;


    public TextMeshProUGUI textoVida;

    public int numeroMaximoVidas = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numeroVidas = numeroMaximoVidas;
        atualizaVidaHud();
    }

    // Update is called once per frame
    public void PerdeVida()
    {
        numeroVidas--;
        atualizaVidaHud();
        Debug.Log("Vida perdida! Vidas restantes: " + numeroVidas);
        if (numeroVidas <= 0)
        {
            Debug.Log("Game Over!");
            // Aqui você pode adicionar lógica para reiniciar o jogo ou finalizar a partida
        }
    }

    public void atualizaVidaHud()
    {
        GameObject hudVidas = GameObject.FindWithTag("HUDVidas");
        if (hudVidas != null)
        {
            textoVida.text = numeroVidas.ToString();
        }
        else
        {
            Debug.LogWarning("HUD Vidas não encontrado!");
        }
    }

    public void settaVidas(int vidas)
    {
        numeroVidas = vidas;
        atualizaVidaHud();
    }

}
