using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkPlacer : MonoBehaviour
{
    public Transform Player;
    public Chunk[] ChunkPrefabs;
    public Chunk FirstChunk;

    private List<Chunk> spawnedChunks = new List<Chunk>();
   
    void Start()
    {
        spawnedChunks.Add(FirstChunk);
       
    }


    void Update()
    {
       
        if (Player.position.x > spawnedChunks[spawnedChunks.Count - 1].End.position.x -15)
{
            SpawnChunk();
           
        }
    }
private void SpawnChunk()
{
        Chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
newChunk.transform.position = spawnedChunks[spawnedChunks.Count - 1].End.position - newChunk.Begin.localPosition;
       spawnedChunks.Add(newChunk);
        if (spawnedChunks.Count >= 3)
{
            Destroy(spawnedChunks[0].gameObject);
            spawnedChunks.RemoveAt(0);
        }
    }
}
