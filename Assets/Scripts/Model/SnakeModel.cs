using System.Collections.Generic;
using UnityEngine;

internal class SnakeModel 
{
    private List<Vector3> _snakeSegments;
    private Vector3 _direction;

    public IReadOnlyList<Vector3> SnakeSegments => _snakeSegments;

    public Vector3 Direction => _direction;

    public SnakeModel()
    {
        _snakeSegments = new List<Vector3>();
        _direction = Vector3.right;
    }

    public void Move()
    {
        Vector3 head = _snakeSegments[0] + _direction;
        _snakeSegments.Insert(0, head);
        _snakeSegments.RemoveAt(_snakeSegments.Count - 1);
    }

    public void ChangeDirection(Vector3 newDirection)
    {
        if (newDirection != -_direction)
        {
            _direction = newDirection;
        }
    }

    public void AddSegment()
    {
        Vector3 tail = _snakeSegments[_snakeSegments.Count - 1];
        _snakeSegments.Add(tail);
    }   
}
