using UnityEngine;

public class moviment_player : MonoBehaviour
{
    public float velocidade = 5f;
    public float velocidadeCorrendo = 10f;

    public float forcaPulo = 7f;

    private bool correndo = false;
    private bool noChao = true;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 movimento = new Vector2(x, y);

        float velocidadeAtual = correndo ? velocidadeCorrendo : velocidade;

        transform.Translate(movimento * velocidadeAtual * Time.deltaTime);

        // PULO
        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            rb.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
            noChao = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            noChao = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PontoCorrida"))
        {
            correndo = true;
        }
    }
}