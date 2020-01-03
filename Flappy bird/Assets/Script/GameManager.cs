using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager = null;
    public bool isActiveColumn = true;
    // Start is called before the first frame update
    [SerializeField] private GameObject prefabcolumn;
    [SerializeField] private int columnSize = 5;// column initialization number add list;
    [SerializeField] private float timeSpawncolumn = 1f;// time spawn bettewn column;
    [SerializeField] private float columnMin = -1f;
    [SerializeField] private float columnMax = 3.5f;

    private GameObject[] ArrCollum;

    private int currrentcolumn=0;//Index of the current column in the collection.
    private float spawnXPosition=10f;// position spawn column follow coordinate axis x
    private Vector2 prefabPosition = new Vector2(-15, -25);// position initialization prefabcolumn
    private float TimeCount;
    public string textSorce;
    void Start()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }
    
        DontDestroyOnLoad(gameObject);
        isActiveColumn = true;
        ArrCollum = new GameObject[columnSize];
        // create list prefab;
        for (int i = 0; i < columnSize; i++)
        {
            ArrCollum[i] = Instantiate(prefabcolumn, prefabPosition,Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        TimeCount += Time.deltaTime;
        if(TimeCount >= timeSpawncolumn && isActiveColumn)
        {
            TimeCount = 0;
            // position spawn column follow coordinate axis y
            float spwanYPosition = Random.Range(columnMin, columnMax);
            ArrCollum[currrentcolumn].transform.position = new Vector3(spawnXPosition, spwanYPosition, 0);
        
            currrentcolumn++;
            if(currrentcolumn >= columnSize)
            {
                currrentcolumn = 0;
            }
        }
    }
}
