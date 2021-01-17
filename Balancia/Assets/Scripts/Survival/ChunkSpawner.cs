using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkSpawner : MonoBehaviour
{
    [SerializeField] int chunkCount;

    [SerializeField] Chunk[] chunks;

    [SerializeField] Chunk firstChunk;

    private List<Chunk> spawnedChunks = new List<Chunk>();
    

    // Start is called before the first frame update
    void Start()
    {
        spawnedChunks.Add(firstChunk);
        for (int i = 0; i <= chunkCount; i++)
        {
            SpawnChunk();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnChunk()
    {
        Chunk newChunk = Instantiate(chunks[Random.Range(0, chunks.Length)]);
        Chunk lastChunk = spawnedChunks[spawnedChunks.Count - 1];

        Transform EndPos = lastChunk.EndPos;

        newChunk.transform.position = EndPos.position;
        newChunk.transform.localEulerAngles = EndPos.localEulerAngles;
        spawnedChunks.Add(newChunk);
    }

}
