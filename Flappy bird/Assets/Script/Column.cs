using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    public static Column ColumnManager ;
    [SerializeField] private float speed;
    public bool isMovingColumn;
    private void Start()
    {
        if(ColumnManager == null)
        {
            ColumnManager = this;
        }
        isMovingColumn = true;

    }
    void Update()
    {
        if (isMovingColumn)
        {
            movingColum();
        }
    }

    private void movingColum()
    {
        Vector3 moving = transform.position;
        moving.x -= speed * Time.deltaTime;
        transform.position = moving;
    }
}
