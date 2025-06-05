using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoReinciciarScript : MonoBehaviour
{
    public void CarregaJogo()
    { 
        Debug.Log("Reiniciando o jogo...");
        SceneManager.LoadScene("CenaDoJogo");
    }
}
