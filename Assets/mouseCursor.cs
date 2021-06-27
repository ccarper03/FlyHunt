using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseCursor : MonoBehaviour
{
    Camera _camera;
    private SpriteRenderer rend;
    public Sprite flySwatted;
    public Sprite normalCursor;
    Vector2 mousePos;
    void Awake()
    {
        _camera = Camera.main;
    }
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;

        if (Input.GetMouseButton(0))
        {
            rend.sprite = flySwatted;
        }
        else
        {
            rend.sprite = normalCursor;
        }
    }
}
