using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 5f;
    public float width;
    public float height;
    private bool movingRight = true;
    public GameObject enemyPrefab;
   private float xmin1;
    private float xmax1;
    private float spawnDelay = 0.5f;
    private float nextPosSound;
    void Start()
    {

        float distanceToCamera = transform.position.z - Camera.main.transform.position.z;

        Vector3 rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distanceToCamera));
        Vector3 leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distanceToCamera));
        xmin1 = leftmost.x;
        xmax1 = rightmost.x;


   
       
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height));
    }

    void SpawnEnemies()
    {

        foreach (Transform child in transform)
        {
            GameObject enemy = Instantiate(enemyPrefab, child.transform.position, Quaternion.identity) as GameObject;
            enemy.transform.parent = child;
        }
    }
    void SpawnUntilFull()
    {
        Transform freePosition = NextFreePosition();
        if (freePosition)
        {
            GameObject enemy = Instantiate(enemyPrefab, freePosition.transform.position, Quaternion.identity) as GameObject;
            enemy.transform.parent = freePosition;
        }
        if (NextFreePosition())
        {
            Invoke ("SpawnUntilFull", spawnDelay);

            DestroyEnemy.Instance1.nextPos();
        }
    }
  
    void Update()
    {
        if (movingRight)
        {
            transform.position += Vector3.right* speed*Time.deltaTime;
        }
        else {
            transform.position += Vector3.left *speed* Time.deltaTime;
        }


        float rightEdge = transform.position.x + (0.5f * width);
       float leftEdge = transform.position.x - (0.5f * width);

        if (leftEdge<xmin1)
        {
            movingRight = !movingRight;
        }else if(rightEdge > xmax1)
        {
            movingRight = false;
           
        }

        if (AllMembersDead())
        {
            SpawnUntilFull();
        }

    }


   public  Transform NextFreePosition()
    {

        foreach (Transform childPositionGameObject in transform)
        {
            if (childPositionGameObject.childCount ==0)
            {

                return childPositionGameObject;
            }
        }
        return null;
    }



    bool AllMembersDead() {

        

        foreach(Transform childPositionGameObject in transform)
        {
            if(childPositionGameObject.childCount > 0){
                return false;

               
            }
        }
        return true;
    }
    

    

    

}
