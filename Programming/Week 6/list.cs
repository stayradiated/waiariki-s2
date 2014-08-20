using System;

namespace Generics {

  // List is a simple linked list implementation
  class List<T> {
    private bool empty;
    private ListNode<T> start;
    private ListNode<T> end;

    // Basic constructor
    public List() {
      this.empty = true;
    }

    // Get and set values using the list[i] syntax
    public T this[int index] {
      get { return this.at(index).Value; }
      set { this.set(index, value); }
    }

    // Count the number of nodes in the list
    public int Length {
      get {
        if (this.empty) return 0;
        int i = 1;
        ListNode<T> current = this.start;
        while (current.Right != null) {
          current = current.Right;
          i += 1;
        }
        return i;
      }
    }

    // Add a new node to the end of the list
    public T Push(T value) {
      ListNode<T> node = new ListNode<T>(value);
      if (this.empty) {
        this.start = this.end = node;
        this.empty = false;
      } else {
        node.Left = this.end;
        this.end.Right = node;
        this.end = node;
      }
      return value;
    }

    // Remove the last node in the list and return it's value
    public T Pop() {
      if (this.empty) {
        return default (T);
      }

      ListNode<T> lastNode = this.end;
      this.end = this.end.Left;
      this.end.Right = null;

      return lastNode.Value;
    }

    // Convert the list into a string
    public override string ToString() {
      string output = "[ ";
      int length = this.Length;
      for (int i = 0; i < length; i++) {
        output += this[i] + " ";
      }
      output += "]";
      return output;
    }

    // Private func to get the node at a certain position
    private ListNode<T> at(int index) {
      if (this.empty) {
        return null;
      }

      ListNode<T> current = this.start;

      for (int i = 0; i < index; i++) {
        current = current.Right;
      }

      return current;
    }

    private void set(int index, T value) {
      ListNode<T> node = this.at(index);
      if (node != null) {
        node.Value = value;
      } else {
        // not sure what do?
        // somehow need to push a bunch of empty nodes into place
      }
    }

  }

  class ListNode<T> {
    public T Value;
    public ListNode<T> Left;
    public ListNode<T> Right;

    public ListNode(T value) {
      this.Value = value;
    }
  }

}
