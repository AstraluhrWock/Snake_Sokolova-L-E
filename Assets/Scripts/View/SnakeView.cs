using System.Collections.Generic;
using UnityEngine;

internal class SnakeView : MonoBehaviour
{
    private GameObject _snakeSegmentPrefab;
    private SnakeViewModel _viewModel;

    private List<GameObject> _snakeSegmentsObjects;

    public void Init()
    {
        _snakeSegmentsObjects = new List<GameObject>();
    }

    public void UpdateView()
    {
        Vector3 newDirection = GetInputDirection();
        _viewModel.ChangeDirection(newDirection);
        UpdateSnakeSegments();
    }

    private Vector3 GetInputDirection()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            return Vector3.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            return Vector3.down;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            return Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            return Vector3.right;
        }
        return Vector3.zero;
    }

    private void UpdateSnakeSegments()
    {
        foreach (GameObject segmentObject in _snakeSegmentsObjects)
        {
            Destroy(segmentObject);
        }
        _snakeSegmentsObjects.Clear();
        foreach (Vector3 segment in _viewModel.SnakeSegments)
        {
            GameObject segmentObject = Instantiate(_snakeSegmentPrefab, segment, Quaternion.identity);
            _snakeSegmentsObjects.Add(segmentObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
