using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallPrefab : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public ScoreManager scoreManager;
    void Start()
    {
        // this is very memory inefficent, as it has to find this, for every single ball, and 
        // i know it can't be that well optimized of a function
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // if the ball gets too low, then we just destroy it
        if (transform.position.y < -20.0)
        {
            // this does that
            Destroy(gameObject);
            scoreManager.deductScore(5);
        }
    }

    // weird thing from video I got, basically
    // if this GameObject collides with another GameObject
    private void OnTriggerEnter(Collider other)
    {
        // if that other game object is tagged with Target
        if(other.gameObject.CompareTag("Target"))
        {
            // Destroy this game object and then move the target
            Destroy(gameObject);
            other.GetComponent<TargetPrefab>().moveRandomly();

        }
    }
}
