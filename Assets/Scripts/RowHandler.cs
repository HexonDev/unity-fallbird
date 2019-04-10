using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowHandler : MonoBehaviour
{

    public Vector3[] RowPositions = new Vector3[3];
    public GameObject RowPrefab;

    public void SpawnRows()
    {
        foreach (var Pos in RowPositions)
        {
            Instantiate(RowPrefab, Pos, Quaternion.Euler(0, 0, 0));
        }
    }

    public void DestroyRows()
    {
        GameObject[] Rows = GameObject.FindGameObjectsWithTag("Score");
        foreach (var Row in Rows)
        {
            Destroy(Row);
        }
    }

    public void StartRowsMoving()
    {
        GameObject[] Rows = GameObject.FindGameObjectsWithTag("Score");
        foreach (var Row in Rows)
        {
            Row.GetComponent<RowMover>().IsPlaying = true;
        }
    }

    
}
