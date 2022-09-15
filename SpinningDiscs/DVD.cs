using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        public bool IsVideo { get; set; }
        public DVD(string name, int storageCapacity, string content, string discType, bool isVideo) : base(name, storageCapacity, content, discType)
        {
            IsVideo = true;
        }

        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
