using System;

namespace Generics {

  class Map<K,T> where K: IComparable {
    private List<MapNode<K,T>> nodes;

    public Map () {
      this.nodes = new List<MapNode<K,T>>();
    }

    // Get and set values in the map
    public T this[K key] {
      get { return this.find(key).Value; }
      set { this.set(key, value); }
    }

    // Find the node that matches the key.
    private MapNode<K,T> find(K key) {
      int i;
      int length = this.nodes.Length;
      MapNode<K, T> node;

      for (i = 0; i < length; i++) {
        node = this.nodes[i];
        if (node == null) break;
        if (node.Key.CompareTo(key) == 0) {
          return node;
        }
      }

      return null;
    }

    // Set a value in the map, reusing the existing node if possible
    private void set(K key, T value) {
      MapNode<K, T> node = this.find(key);
      if (node != null) {
        node.Value = value;
      } else {
        this.nodes.Push(new MapNode<K, T>(key, value));
      }
    }
  }

  class MapNode<K,T> {
    public K Key;
    public T Value;

    public MapNode(K key) {
      this.Key = key;
      this.Value = default(T);
    }

    public MapNode(K key, T value) {
      this.Key = key;
      this.Value = value;
    }
  }

}
