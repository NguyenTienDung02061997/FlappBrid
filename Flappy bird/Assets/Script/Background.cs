using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public static Background instanceBackground = null;
    public bool MovingBackground = true;
    private float movingBackgroundSpeed= -5f;
    Vector2 startPosBackground;

    private void Start()
    {
        startPosBackground = transform.position;
        if(instanceBackground == null)
        {
            instanceBackground = this;
        }
        else if(instanceBackground != this)
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (MovingBackground)
        {
            //Mathf.Repeat Vòng lặp giá trị t, sao cho nó không bao giờ lớn hơn chiều dài và không bao giờ nhỏ hơn 0
            float posBackground = Mathf.Repeat(Time.time * movingBackgroundSpeed, 20);
            transform.position = startPosBackground + Vector2.right * posBackground;
        }
    }
}
