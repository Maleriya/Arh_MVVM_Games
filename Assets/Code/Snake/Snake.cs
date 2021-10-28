using System.Collections.Generic;
using UnityEngine;

namespace SnakeBase
{
    public class Snake : MonoBehaviour
    {
        private List<Transform> _segments = new List<Transform>();
        [SerializeField] private Transform _segmentPrefab;
        [SerializeField] private Vector2 _direction = Vector2.right;
        [SerializeField] private int _initialSize = 4;
        [SerializeField] private float _speed = 0.2f;
        private float _timeSpeed;

        private void Start()
        {
            ResetState();
        }

        private void Update()
        {
            if (this._direction.x != 0f)
            {
                if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
                {
                    this._direction = Vector2.up;
                }
                else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
                {
                    this._direction = Vector2.down;
                }
            }

            else if (this._direction.y != 0f)
            {
                if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
                {
                    this._direction = Vector2.right;
                }
                else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    this._direction = Vector2.left;
                }
            }
        }

        private void FixedUpdate()
        {
            if (_timeSpeed < _speed)
            {
                _timeSpeed += Time.deltaTime;
                return;
            }

            _timeSpeed = 0.0f;

            for (int i = _segments.Count - 1; i > 0; i--)
            {
                _segments[i].position = _segments[i - 1].position;
            }

            float x = Mathf.Round(this.transform.position.x) + this._direction.x;
            float y = Mathf.Round(this.transform.position.y) + this._direction.y;

            this.transform.position = new Vector2(x, y);
        }

        public void Grow()
        {
            Transform segment = Instantiate(this._segmentPrefab);
            segment.position = _segments[_segments.Count - 1].position;

            _segments.Add(segment);
        }

        public void ResetState()
        {
            this._direction = Vector2.right;
            this.transform.position = Vector3.zero;

            for (int i = 1; i < _segments.Count; i++)
            {
                Destroy(_segments[i].gameObject);
            }

            _segments.Clear();
            _segments.Add(this.transform);

            for (int i = 0; i < this._initialSize - 1; i++)
            {
                Grow();
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.GetComponent<Food>())
            {
                Grow();
            }
            else
            {
                ResetState();
            }
        }

    }
}

