
using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    public float intensidade = 0.15f;
    public float duracao = 0.3f;

    private Vector3 posicaoInicial;

    void Awake()
    {
        posicaoInicial = transform.localPosition;
    }

    public void TremerCamera()
    {
        StopAllCoroutines();
        StartCoroutine(Tremedeira());
    }

    IEnumerator Tremedeira()
    {
        float tempo = 0;

        while (tempo < duracao)
        {
            float x = Random.Range(-1f, 1f) * intensidade;
            float y = Random.Range(-1f, 1f) * intensidade;

            transform.localPosition = posicaoInicial + new Vector3(x, y, 0);

            tempo += Time.deltaTime;
            yield return null;
        }

        transform.localPosition = posicaoInicial;
    }
}
