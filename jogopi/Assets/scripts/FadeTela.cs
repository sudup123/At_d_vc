using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeTela : MonoBehaviour
{
    public Image tela;

    [Header("Tempos")]
    public float tempoEscurecer = 1f;
    public float tempoPreta = 2f;
    public float tempoClarear = 1f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Efeito());
        }
    }

    IEnumerator Efeito()
    {
        // Escurece
        yield return StartCoroutine(MudarAlpha(0, 1, tempoEscurecer));

        // Fica preta
        yield return new WaitForSeconds(tempoPreta);

        // Volta ao normal
        yield return StartCoroutine(MudarAlpha(1, 0, tempoClarear));
    }

    IEnumerator MudarAlpha(float inicio, float fim, float tempo)
    {
        float contador = 0;
        Color cor = tela.color;

        while (contador < tempo)
        {
            contador += Time.deltaTime;

            cor.a = Mathf.Lerp(inicio, fim, contador / tempo);
            tela.color = cor;

            yield return null;
        }

        cor.a = fim;
        tela.color = cor;
    }
}