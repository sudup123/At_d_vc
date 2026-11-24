
using UnityEngine;
using TMPro;
using System.Collections;

public class TextoFlutuante : MonoBehaviour
{
    public TMP_Text texto;
    [TextArea]
    public string mensagem;
    public float duracao = 3f;

    private bool ativado = false;

    void Start()
    {
        texto.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !ativado)
        {
            ativado = true;
            texto.text = mensagem;
            texto.gameObject.SetActive(true);

            StartCoroutine(EsconderTexto());
        }
    }

    IEnumerator EsconderTexto()
    {
        yield return new WaitForSeconds(duracao);

        texto.gameObject.SetActive(false);
        ativado = false;
    }
}
