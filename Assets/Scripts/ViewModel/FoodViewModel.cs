using UnityEngine;
internal class FoodViewModel
{
    private FoodModel _model;

    public FoodViewModel(FoodModel foodModel)
    {
        _model = foodModel;
    }
    public Vector3 Position => _model.Position;
}