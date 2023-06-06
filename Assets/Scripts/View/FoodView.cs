using UnityEngine;

internal class FoodView : MonoBehaviour
{
    private GameObject _foodPrefab;
    private GameObject _foodObject;

    public void Init(FoodViewModel foodViewModel)
    {
        _foodObject = Instantiate(_foodPrefab, foodViewModel.Position, Quaternion.identity);
    }

    public void UpdateView(FoodViewModel foodViewModel)
    {
        if (foodViewModel.Position != _foodObject.transform.position)
        {
            _foodObject.transform.position = foodViewModel.Position;
        }
    }
}