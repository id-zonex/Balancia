using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkSpawner : MonoBehaviour
{
    [SerializeField] private float _saveZone;
    [SerializeField] private Transform _player;

    [SerializeField] private int _maxChunksCount;

    [SerializeField] private Chunk[] _chunks;
    [SerializeField] private Chunk _firstChunk;

    private List<Chunk> spawnedChunks = new List<Chunk>();
    private Chunk lastChunk;


    private void Start()
    {
        spawnedChunks.Add(_firstChunk);
        lastChunk = _firstChunk;
    }

    private void Update()
    {
        if(Vector3.Distance(_player.position, lastChunk.transform.position) < 20)
        {
            TryDelChunk();
            SpawnChunk();
        }
    }

    private void SpawnChunk()
    {
        Chunk newChunk = GetRandomChunk();
        SetChunkRotationAndPosition(newChunk);
        spawnedChunks.Add(newChunk);

    }

    private void TryDelChunk()
    {
        print(spawnedChunks.Count > _maxChunksCount);
        if (spawnedChunks.Count > _maxChunksCount)
        {
            print("Remove");
            Destroy(spawnedChunks[0].gameObject);
            spawnedChunks.RemoveAt(0);
        }
    }

    private void SetChunkRotationAndPosition(Chunk newChunk)
    {
        lastChunk = spawnedChunks[spawnedChunks.Count - 1];

        Transform EndPos = lastChunk.EndPos;

        newChunk.SetRotation(lastChunk.NextRotation);
        newChunk.transform.position = newChunk.MidlePos.position - newChunk.StartPos.position + EndPos.position;
    }

    private Chunk GetRandomChunk()
    {
        return Instantiate(_chunks[Random.Range(0, _chunks.Length)]);
    }


}
