using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFx;
    [SerializeField] Transform parent;
    [SerializeField] int points = 1000;
    [SerializeField] int healthPoints = 100;
    [SerializeField] int hits = 3;
    [SerializeField] float scaleFactor = .75f;

    ScoreBoard scoreBoard;


    // Start is called before the first frame update
    void Start()
    {

        AddBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void AddBoxCollider()
    {
        Collider enemyCollider = gameObject.AddComponent<BoxCollider>();
        enemyCollider.isTrigger = false;
    }


    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        if (hits <= 1)
        {
            onEnemyDeath();
        }
    }

    private void ProcessHit()
    {
        GameObject fx = Instantiate(deathFx, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        fx.transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
        scoreBoard.ScoreHit(points);
        hits--;
    }

    private void onEnemyDeath()
    {
        GameObject fx = Instantiate(deathFx, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(gameObject);
    }
}
