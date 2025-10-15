using UnityEngine;

public class Cursor_Tail : MonoBehaviour
{
    [SerializeField] GameObject Anchor;
    [SerializeField] Tail_Controller tc;
    Vector3 mousePos;
    Vector3 AnchPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AnchPos = Anchor.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        tc.TailPos(mousePos, AnchPos);

    }
}
