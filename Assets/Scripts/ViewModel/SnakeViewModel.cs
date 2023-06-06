using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class SnakeViewModel : MonoBehaviour
{
    private SnakeModel _model;

    public SnakeViewModel(SnakeModel snakeModel)
    {
        _model = snakeModel;
    }
    public IReadOnlyList<Vector3> SnakeSegments => _model.SnakeSegments;

    public void ChangeDirection(Vector3 newDirection)
    {
        _model.ChangeDirection(newDirection);
    }
}
