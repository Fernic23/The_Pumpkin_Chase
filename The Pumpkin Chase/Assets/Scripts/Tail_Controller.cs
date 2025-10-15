using UnityEngine;

public class Tail_Controller : MonoBehaviour
{
    LineRenderer tail; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tail = GetComponent<LineRenderer>();
        tail.positionCount = 2; 
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(Input.mousePosition.normalized);
    }

    public void TailPos(Vector3 mousePos, Vector3 Anchor)
    {
        tail.SetPosition(0, new Vector3(Anchor.x, Anchor.y, -1f));
        tail.SetPosition(1, new Vector3(mousePos.x, mousePos.y, -1f));
    }

}
