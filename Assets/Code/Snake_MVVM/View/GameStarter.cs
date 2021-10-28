using UnityEngine;
using Snake_MVVM.ModelView;
using Snake_MVVM.Model;

namespace Snake_MVVM.View
{
    public sealed class GameStarter : MonoBehaviour
    {
        [SerializeField] private TimerV _timer;
        [SerializeField] private GameObject _pieceV;
        [SerializeField] private InputV _input;
        [SerializeField] private GameObject _foodV;
        [SerializeField] private Collider2D _foodArea;

        private Snake _snake;

        private void Start()
        {
            var food = new SnakeFood(_foodArea);
            var foodVM = new FoodVM(food);
            var foodV = GameObject.Instantiate(_foodV, new Vector2(food.Position.x, food.Position.y), Quaternion.identity);
            foodV.GetComponent<FoodV>().Initialize(foodVM);
            foodV.GetComponent<FoodV>().eatFood += CreatePiece;
            _snake = new Snake(3);
            new TimerVM(_snake, _timer);
            foreach (var piece in _snake.AllPiece)
            {
                var pieceView = GameObject.Instantiate(_pieceV, new Vector2(piece.Position.x, piece.Position.y), Quaternion.identity);
                var moveVM = new MoveVM(piece, _timer);
                pieceView.GetComponent<PieceV>().Initialize(moveVM);
                if (piece is SnakeHead head)
                {
                    var inputVM = new InputVM(head);
                    _input.Initialize(inputVM);
                    pieceView.AddComponent<SnakeHeadV>();
                }
            }
        }

        private void CreatePiece()
        {
            var piece = _snake.AddPiece();
            var pieceView = GameObject.Instantiate(_pieceV, new Vector2(piece.Position.x, piece.Position.y), Quaternion.identity);
            var moveVM = new MoveVM(piece, _timer);
            pieceView.GetComponent<PieceV>().Initialize(moveVM);
        }
    }
}