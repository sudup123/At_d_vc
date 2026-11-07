
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    public Sprite idle;
    public Sprite walkRight;
    public Sprite walkLeft;

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            sr.sprite = walkLeft;
            Debug.Log("Sprite esquerda: " + walkLeft.name);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            sr.sprite = walkRight;
            Debug.Log("Sprite direita: " + walkRight.name);
        }
        else
        {
            sr.sprite = idle;
        }
    }
}
