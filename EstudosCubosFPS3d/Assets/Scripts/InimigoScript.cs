using UnityEngine;

public class InimigoScript : MonoBehaviour
{
    private GameObject jogador;
    public float velocidadeInimigo = 0.02f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jogador = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.LookAt(jogador.transform.position);
        this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, jogador.transform.position, velocidadeInimigo);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bala"))
        {
            this.gameObject.GetComponent<StatusInimigoScript>().removeVida();
            // Aqui você pode adicionar a lógica para o que acontece quando o inimigo colide com o jogador
        }
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Dei uma cubada no jogador!");
            Destroy(this.gameObject);
        }
    }
}
