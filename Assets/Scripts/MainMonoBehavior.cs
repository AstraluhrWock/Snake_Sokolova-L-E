using UnityEngine;

internal class MainMonoBehavior : MonoBehaviour
{
    [SerializeField] private int maxX = 15;
    [SerializeField] private int maxY = 15;

    private SnakeView _snakeView;
    private FoodView _foodView;

    private SnakeModel _snakeModel;
    private FoodModel _foodModel;

    private SnakeViewModel _snakeViewModel;
    private FoodViewModel _foodViewModel;

    private void Start()
    {
        _snakeModel = new SnakeModel();
        _snakeViewModel = new SnakeViewModel(_snakeModel);
        _snakeView = new SnakeView();
        _snakeView.Init();

        _foodModel = new FoodModel();
        _foodViewModel = new FoodViewModel(_foodModel);
        _foodView = new FoodView();
        _foodView.Init(_foodViewModel);  
    }

    private void Update()
    {
        if (_foodModel == null)
        {
            _foodModel.GenerateNewPosition(maxX,maxY);
        }
        _foodView.UpdateView(_foodViewModel);
        _snakeView.UpdateView();
    }

}

