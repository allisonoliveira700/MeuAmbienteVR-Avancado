using UnityEngine;

public class ColorInteraction : MonoBehaviour
{
    [Header("Configuração de Distância")]
    public float distancia = 3f;

    [Header("Configuração da Luz")]
    public Light pontoLuz;
    public float intensidadeNormal = 1f;
    public float intensidadeProximo = 5f;

    [Header("Configuração da Cor")]
    public Color corNormal = new Color(1f, 0.95f, 0.8f);
    public Color corProximo = new Color(1f, 1f, 0.5f);

    private Transform player;
    private Renderer rend;
    private bool estaProximo = false;

    void Start()
    {
        player = Camera.main.transform;
        rend = GetComponent<Renderer>();
        rend.material.color = corNormal;

        if (pontoLuz != null)
            pontoLuz.intensity = intensidadeNormal;
    }

    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.position);

        if (dist < distancia && !estaProximo)
        {
            estaProximo = true;
            rend.material.color = corProximo;
            if (pontoLuz != null)
                pontoLuz.intensity = intensidadeProximo;
        }
        else if (dist >= distancia && estaProximo)
        {
            estaProximo = false;
            rend.material.color = corNormal;
            if (pontoLuz != null)
                pontoLuz.intensity = intensidadeNormal;
        }
    }
}