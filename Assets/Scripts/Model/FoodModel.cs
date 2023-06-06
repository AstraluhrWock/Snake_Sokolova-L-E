using UnityEngine;
internal class FoodModel
{
    private Vector3 _position;

    public Vector3 Position => _position;

    public void GenerateNewPosition(int maxX, int maxY)
    {
        _position = new Vector3(Random.Range(0, maxX), Random.Range(0, maxY), 0);
    }

}