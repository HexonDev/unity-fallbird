using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowMover : MonoBehaviour {

    public Transform[] blocks;
    public float moveSpeed = 0.1f;
    public Vector3 resetPosition;
    public float resetDistanceY;
    public bool IsPlaying = false;

    void Start()
    {

        /*blocks = new Transform[this.transform.childCount];

        for (int i = 0; i < this.transform.childCount; i++)
        {
            blocks[i] = this.transform.GetChild(i);
        }*/

        RemoveBlocks();
    }

    void Update()
    {
        if (IsPlaying)
        {
            MoveRow();
            RespawnRow();
        }
            
    }

    

    void RemoveBlocks()
    {
        int num = Random.Range(1, 8);

        this.transform.GetChild(num).gameObject.SetActive(false);
        this.transform.GetChild(num + 1).gameObject.SetActive(false);
    }

    void ResetBlocks()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            if (!this.transform.GetChild(i).gameObject.activeSelf)
            {
                this.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }

    void MoveRow()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + moveSpeed);
    }

    void RespawnRow()
    {
        if (this.transform.position.y >= resetDistanceY)
        {
            this.transform.position = resetPosition;
            ResetBlocks();
            RemoveBlocks();
        }
    }
}
