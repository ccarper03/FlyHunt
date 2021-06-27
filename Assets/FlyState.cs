using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyState : MonoBehaviour
{
    private SpriteRenderer rend;
    [SerializeField]
    private bool isSquished = false;
    public Sprite flyNormal;
    public Sprite flySquashed;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isSquished)
        {
            rend.sprite = flySquashed;
        }
        if (!isSquished)
        {
            rend.sprite = flyNormal;
        }
    }
    private void OnMouseDown()
    {
        GetComponent<FlyMovement>().speed = 0;
        isSquished = true;
    }
    public void Reset()
    {
        isSquished = false;
    }
}
