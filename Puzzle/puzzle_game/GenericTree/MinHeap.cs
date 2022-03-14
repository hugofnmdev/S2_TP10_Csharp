using System;
using System.Data.SqlTypes;

class MinHeap <T> where T : class
{

    // Member variables of this class
    private HeapElement<T>[] Heap;
    private int size;
    private int maxsize;

    // Initializing front as static with unity
    private int FRONT = 1;

    // Constructor of this class
    public MinHeap(int maxsize)
    {
        // This keyword refers to current object itself
        this.maxsize = maxsize;
        this.size = 0;

        Heap = new HeapElement<T>[this.maxsize + 1];
        Heap[0] = new HeapElement<T>(null, Int32.MinValue);
    }
    // Method 1
    // Returning the position of
    // the parent for the node currently
    // at pos
    public int parent(int pos) { return pos / 2; }

    // Method 2
    // Returning the position of the
    // left child for the node currently at pos
    public int leftChild(int pos) { return (2 * pos); }

    // Method 3
    // Returning the position of
    // the right child for the node currently
    // at pos
    public int rightChild(int pos)
    {
        return (2 * pos) + 1;
    }

    // Method 4
    // Returning true if the passed
    // node is a leaf node
    public bool isLeaf(int pos)
    {

        if (pos > (size / 2) && pos <= size) {
            return true;
        }

        return false;
    }

    // Method 5
    // To swap two nodes of the heap
    public void swap(int fpos, int spos)
    {

        HeapElement<T> tmp = Heap[fpos];

        Heap[fpos] = Heap[spos];
        Heap[spos] = tmp;
    }

    // Method 6
    public void minHeapify(int pos)
    {
        // FIXME
        throw new NotImplementedException();
    }

    // Method 7
    public void Enqueue(HeapElement<T> element)
    {
        // FIXME
        throw new NotImplementedException();
    }

    // Method 9
    public HeapElement<T> Dequeue()
    {
        // FIXME
        throw new NotImplementedException();
    }
}

public class HeapElement<T> where T : class
{
    private int value;
    public int Value => value;

    private T node;
    public T Node => node;

    public HeapElement(T node, int value)
    {
        this.node = node;
        this.value = value;
    }
}

