using System.Collections.Generic;
using UnityEngine;

internal class List : List<Transform>
{
    public List(IEnumerable<Transform> collection) : base(collection)
    {
    }
}