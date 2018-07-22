using System;
using System.Collections.Generic;

/*
 * A TrainComposition is built by attaching and detaching wagons from the left and the right sides.
 * For example, if we start by attaching wagon 7 from the left followed by attaching wagon 13, 
 * again from the left, we get a composition of two wagons (13 and 7 from left to right). 
 * Now the first wagon that can be detached from the right is 7 and the first that can be detached from the left is 13.
 * Implement a TrainComposition that models this problem.
*/

namespace TrainComposition
{
    class TrainComposition
    {
        LinkedList<int> _train;

        public TrainComposition()
        {
            _train = new LinkedList<int>();
        }

        public void AttachWagonFromLeft(int wagonId)
        {
            _train.AddFirst(wagonId);
        }

        public void AttachWagonFromRight(int wagonId)
        {
            _train.AddLast(wagonId);
        }

        public int DetachWagonFromLeft()
        {
            var x = _train.First.Value;
            _train.RemoveFirst();
            return x;
        }

        public int DetachWagonFromRight()
        {
            var x = _train.Last.Value;
            _train.RemoveLast();
            return x;
        }

        public static void Main(string[] args)
        {
            TrainComposition train = new TrainComposition();
            train.AttachWagonFromLeft(7);
            train.AttachWagonFromLeft(13);
            Console.WriteLine(train.DetachWagonFromRight()); // 7 
            Console.WriteLine(train.DetachWagonFromLeft()); // 13
        }
    }
}
