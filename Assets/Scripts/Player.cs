using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _playerTransform.Translate(0, _speed * Time.deltaTime,0);

        }

        if (Input.GetKey(KeyCode.S))
        {
            _playerTransform.Translate(0, _speed * Time.deltaTime*-1, 0);

        }

        if (Input.GetKey(KeyCode.A))
        {
            _playerTransform.Translate(_speed * Time.deltaTime*-1, 0, 0);

        }

        if (Input.GetKey(KeyCode.D))
        {
            _playerTransform.Translate(_speed * Time.deltaTime , 0, 0);

        }


    }

    public void PlantSeed ()
    {
        
    }
}
