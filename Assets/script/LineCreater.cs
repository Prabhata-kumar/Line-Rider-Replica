using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreater : MonoBehaviour
{
    public GameObject lineRenderer;
    Lines activeLine;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject LineGo = Instantiate(lineRenderer);
            activeLine = LineGo.GetComponent<Lines>();
        }
        if (Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }
            if (activeLine != null)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.transform.position = mousePos;
        }
    }
}
