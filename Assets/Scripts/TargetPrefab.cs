using UnityEngine;
public class TargetPrefab : MonoBehaviour
{

    private ScoreManager scoreManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // we find the score manager object in the scene, and set it to this so we can communicate with it.
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    // if this is called, we can assume that the target was hit with a ball
    // so we then not only move the target, but add to the score
    public void moveRandomly()
    {
        transform.position = new Vector3(Random.Range(-15, 15), Random.Range(-15,15), Random.Range(10, 30));
        scoreManager.addScore(10);
    }

}
