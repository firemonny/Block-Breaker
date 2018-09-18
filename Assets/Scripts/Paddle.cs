using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //configuration parameters
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 0f;
    [SerializeField] float maxX = 16f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnit = (Input.mousePosition.x / Screen.width * screenWidthInUnits);
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);

        paddlePos.x = Mathf.Clamp(mousePosInUnit, minX, maxX);
        transform.position = paddlePos;
    }
}
