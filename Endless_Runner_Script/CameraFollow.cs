using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject tileToSpawn;
    public GameObject referenceObject;
    public float timeOffset = 0.4f;
    public float distanceBetweenTiles = 5.0F;
    public float randomValue = 0.8f;
    private Vector3 previousTilePosition;
    private float startTime;
    private Vector3 direction, mainDirection = new Vector3(0, 0, 1), otherDirection = new Vector3(1, 0, 0);
    public Transform player;
    Vector3 offset;
    // Start is called before the first frame update
    private void Start()
    {
        
        offset = transform.position - player.position;
        previousTilePosition = referenceObject.transform.position;
        startTime = Time.time;
        
       
    }

    // Update is called once per frame
    private void Update()
    {
// Tiles Spwan .....................................
        if (Time.time - startTime > timeOffset)
        {
            if (Random.value < randomValue)
                direction = mainDirection;
            else
            {
                Vector3 temp = direction;
                direction = otherDirection;
                mainDirection = direction;
                otherDirection = temp;
            }
            Vector3 spawnPos = previousTilePosition + distanceBetweenTiles * direction;
            startTime = Time.time;
            Instantiate(tileToSpawn, spawnPos, Quaternion.Euler(0, 0, 0));
            previousTilePosition = spawnPos;
        }
        //............................Tiles Spwan End...........................
      //  transform.position = player.position + offset;
    }
    
}
