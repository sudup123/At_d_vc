using UnityEngine;

public class moviment_player : MonoBehaviour
{
    public float velocidade = 5f;
    public float velocidadeCorrendo = 10f;

    private bool correndo = false;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 movimento = new Vector2(x, y);

        float velocidadeAtual = correndo ? velocidadeCorrendo : velocidade;

        transform.Translate(movimento * velocidadeAtual * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PontoCorrida"))
        {
            correndo = true;
        }
    }
}