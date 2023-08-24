using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellScript : MonoBehaviour
{
    private Vector2 touchVector2;
    private CellState state;

    // Start is called before the first frame update
    void Start()
    {
        touchVector2 = Vector2.zero;
        state = CellState.Close;
    }

    // Update is called once per frame
    void Update()
    {

#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            state = CellState.Click;
            touchVector2 = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (state == CellState.Click)
            {
                state = CellState.Open;
                // Open Trigger
            }

            touchVector2 = Vector2.zero;
        }
#else
        if (Input.touchCount > 0)
        { 
            touchVector2 = Input.GetTouch(0).position;
        }
#endif
    }

}
