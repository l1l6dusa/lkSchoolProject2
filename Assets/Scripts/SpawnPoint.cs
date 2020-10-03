using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [Range(0,3)][SerializeField] private float _spawnAreaRadius;
    [SerializeField] private GameObject _spawnObject;
    
    public void Spawn()
    {
        
       
        
            var spawnPosition = new Vector2(
                Random.Range(transform.position.x-_spawnAreaRadius, transform.position.x+_spawnAreaRadius),
                Random.Range(transform.position.y-_spawnAreaRadius,transform.position.y+_spawnAreaRadius)
                );
            Instantiate(_spawnObject, spawnPosition, Quaternion.identity).transform.SetParent(this.transform);

    }
}
    

