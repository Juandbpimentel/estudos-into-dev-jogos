using UnityEngine;

public class InicializaInimigo : MonoBehaviour
{
    public GameObject inimigoPrefab;
    public int qtdInimigos = 50;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < qtdInimigos; i++)
        {
            GameObject inimigo = Instantiate(inimigoPrefab);
            float distanciax = Random.Range(-25.0f, 25.0f);
            float distanciaz = Random.Range(-25.0f, 25.0f);
            distanciax = distanciax < 0 ? distanciax - 5 : distanciax + 5;
            distanciaz = distanciaz < 0 ? distanciaz - 5 : distanciaz + 5;

            inimigo.transform.position = new Vector3(distanciax, 2, distanciaz);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
