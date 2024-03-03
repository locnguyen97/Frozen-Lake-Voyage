using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObjectMoveByDrag : MonoBehaviour
{
    [SerializeField] List<GameObject> particleVFXs;

    private Vector3 startPos;
    private Transform target;

    private void OnEnable()
    {
        startPos = transform.position;
    }

    public void PickUp()
    {
        //transform.rotation = new Quaternion(0,0,0,0);
    }

    public void CheckOnMouseUp()
    {
        GameManager.Instance.CheckLevelUp();
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("ca"))
        {
            collision.transform.GetChild(0).gameObject.SetActive(true);
            collision.transform.GetComponent<SpriteRenderer>().enabled = false;
            collision.transform.GetComponent<Collider2D>().enabled = false;
            GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].RemoveObject(collision.gameObject);
            
        }
    }
    
}
