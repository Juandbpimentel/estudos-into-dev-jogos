using UnityEngine;

public class StatusInimigoScript : MonoBehaviour
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
        Debug.Log("Levei foi bala ;-;! Vidas restantes: " + vidas);
        if (vidas == 0)
        {
            Debug.Log("Cubo Morrido!");
            StopAllCoroutines();
            Destroy(this.gameObject);
        }
    }
}
